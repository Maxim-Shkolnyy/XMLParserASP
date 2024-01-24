using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Xml;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using Z.EntityFramework.Plus;

namespace xmlParserASP.Services;

public class UpdatePriceQuantityService
{
    private MmSupplierXmlSetting? _supplierXmlSetting;
    private readonly GammaContext _dbContextGamma;
    private string? _suppName;
    private List<(string, string)>? _stateMessages;
    private string _currentTableDbColumnToUpdate = "";
    Dictionary<string, string> xmlModelPriceList = new();

    public UpdatePriceQuantityService(MmSupplierXmlSetting supplierXmlSetting, GammaContext dbContextGamma)
    {
        _dbContextGamma = dbContextGamma;
        _supplierXmlSetting = supplierXmlSetting;
    }

    public async Task<List<(string, string)>> MasterUpdatePriceQtyClass(List<int> settingsId, string tableDbColumnToUpdate)
    {
        _currentTableDbColumnToUpdate = tableDbColumnToUpdate;

        _stateMessages = new();

        if (settingsId == null)
        {
            _stateMessages.Add(("1_Setting ID was not passed", "red"));
            return _stateMessages;
        }

        #region Get current values from DB and add them to new 'dbCodeModelPriceList' on each iteration

        foreach (int id in settingsId)
        {
            _supplierXmlSetting = await _dbContextGamma.MmSupplierXmlSettings
                .Where(m => m.SupplierXmlSettingId == id)
                .FirstOrDefaultAsync();
            if (_supplierXmlSetting == null)
            {
                _stateMessages.Add(("1_Supplier setting was not found in DB", "red"));
                continue;
            }

            _suppName = (await _dbContextGamma.MmSuppliers.FirstOrDefaultAsync(m => m.SupplierId == _supplierXmlSetting.SupplierId))?.SupplierName;

            if (_suppName == null)
            {
                _stateMessages.Add(("1_Supplier name was not found in DB", "red"));
                continue;
            }

            var currentSuppProductsList = await _dbContextGamma.NgProductToSuppliers
                .Where(m => m.SupplierId == _suppName)
                .Select(m => m.ProductId)
                .ToListAsync();

            if (currentSuppProductsList == null)
            {
                _stateMessages.Add(($"1_Supplier {_suppName} has no one product in DB", "red"));
                continue;
            }

            var products = await _dbContextGamma.NgProducts
                .Where(p => currentSuppProductsList.Contains(p.ProductId))
                .Select(m => new ProductMinInfoModel
                {
                    ProductId = m.ProductId,
                    Sku =  m.Sku,
                    Model = m.Model,
                    Price = m.Price,
                    Quantity = m.Quantity
                }).ToListAsync();


            List<(string, string, string, string)> dbCodeModelPriceList = new();

            string priceQuantityValue = "";
            string productName = "";

            foreach (var product in products)
            {
                try
                {
                    if (_currentTableDbColumnToUpdate == "Price")
                    {
                        priceQuantityValue = product.Price.ToString(CultureInfo.CurrentCulture);
                        productName = _dbContextGamma.NgProductDescriptions.Where(n => n.ProductId == product.ProductId).Select(m => m.Name).FirstOrDefault();
                    }
                    else
                    {
                        priceQuantityValue = product.Quantity.ToString();
                        productName = _dbContextGamma.NgProductDescriptions.Where(n => n.ProductId == product.ProductId).Select(m => m.Name).FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing field {product.Sku} : {ex.Message}");
                }

                dbCodeModelPriceList.Add((product.Sku, product.Model, priceQuantityValue, productName));
            }
            #endregion




            if ((_suppName == "Gamma" || _suppName == "Gamma-K") & _currentTableDbColumnToUpdate == "Quantity")
            {
                GetGammaQtyXmlValues();
            }
            else if (_suppName == "Kanlux")
            {
                int modelColumnNumber;

                // TODO: Move TryParse to method GetExcelValues and parse it there

                if (!int.TryParse(_supplierXmlSetting.ModelXlColumn, out modelColumnNumber))
                {
                    _stateMessages.Add(($"1_{_suppName} model column number in excel file was not converted successful, model column set to 1", "red"));
                    modelColumnNumber = 1;
                }

                int priceColumnNumber;
                if (!int.TryParse(_supplierXmlSetting.PicturePriceQuantityXlColumn, out priceColumnNumber))
                {
                    _stateMessages.Add(($"1_{_suppName} price or quantity column number in excel file was not converted successful, price or quantity column set to 2", "red"));
                    priceColumnNumber = 2;
                }


                if (_currentTableDbColumnToUpdate == "Price" & _supplierXmlSetting.SettingName == "Kanlux_price_XL")
                {
                    GetExcelValues("", "", "", _supplierXmlSetting.Path, modelColumnNumber, priceColumnNumber);
                }

                if (_currentTableDbColumnToUpdate == "Quantity" & _supplierXmlSetting.SettingName == "Kanlux_qty_XL")
                {
                    GetExcelValues("", "", "", _supplierXmlSetting.Path, modelColumnNumber, priceColumnNumber);
                }
            }
            else if (_suppName == "Feron")
            {
                if (_currentTableDbColumnToUpdate == "Quantity" & _supplierXmlSetting.SettingName == "Feron_excel")
                {
                    GetFeronQtyXlValues("", "", "", _supplierXmlSetting.Path, _supplierXmlSetting.ModelXlColumn, _supplierXmlSetting.PicturePriceQuantityXlColumn, _supplierXmlSetting.QtyInBoxColumnNumber);
                }
            }
            else
            {
                GetXmlValues();
            }

            if (_currentTableDbColumnToUpdate == "Price")
            {
                UpdatePrices(dbCodeModelPriceList, xmlModelPriceList);
            }
            else
            {
                UpdateQuantity(dbCodeModelPriceList, xmlModelPriceList);
            }

            _stateMessages.Add(($"{_suppName} {_currentTableDbColumnToUpdate} updated successful", "green"));

        }
        _stateMessages = _stateMessages.OrderBy(m => m.Item1).ToList();
        return _stateMessages;
    }

    #region Get xml and excel values from all suppliers unloads and add it to 'xmlModelPriceList'

    private void GetXmlValues()
    {
        XmlDocument xmlDoc = new();

        string fileExtension = Path.GetExtension(_supplierXmlSetting.Path);
        string priceOrQuantityNode = "";

        xmlModelPriceList.Clear();

        xmlDoc.Load(_supplierXmlSetting.Path);
        
        // xmlDoc.LoadXml(_supplierXmlSetting.Path);
        

        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(_supplierXmlSetting.ProductNode);

        if (_supplierXmlSetting.MainProductNode != null)  //Main node need to Proforma etc
        {
            XmlNodeList parentItemsList = xmlDoc.GetElementsByTagName(_supplierXmlSetting.MainProductNode);

            foreach (XmlNode items in parentItemsList)
            {
                foreach (XmlNode item in itemsList)
                {
                    string? model = null;

                    if (_supplierXmlSetting.ParamAttribute == null)
                    {
                        model = item.SelectSingleNode(_supplierXmlSetting.ModelNode)?.InnerText;

                        if (String.IsNullOrEmpty(model))
                        {
                            _stateMessages.Add(($"error_{_suppName}_{item.SelectSingleNode(_supplierXmlSetting.ModelNode)} NOT FOUND in xml", "red"));
                        }
                    }
                    else
                    {
                        if (item.Attributes["id"] != null)
                        {
                            if (item.SelectSingleNode(_supplierXmlSetting.ModelNode) == null)
                            {
                                _stateMessages.Add(($"error_{_suppName}_{item.SelectSingleNode(_supplierXmlSetting.ModelNode)} NOT FOUND in xml", "red"));
                                continue;
                            }

                            model = item.Attributes["id"]?.Value;

                            if (String.IsNullOrEmpty(model))
                            {
                                _stateMessages.Add(($"error_{_suppName}_{item.SelectSingleNode(_supplierXmlSetting.ModelNode)} NOT FOUND in xml", "red"));
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (_currentTableDbColumnToUpdate == "Price")
                    {
                        priceOrQuantityNode = item.SelectSingleNode(_supplierXmlSetting.PriceNode)?.InnerText ?? "";
                        if (priceOrQuantityNode == null)
                        {
                            _stateMessages.Add(($"error_{_suppName}_{item.SelectSingleNode(_supplierXmlSetting.PriceNode)} NOT FOUND in xml", "red"));
                        }
                    }
                    else
                    {
                        priceOrQuantityNode = item.SelectSingleNode(_supplierXmlSetting.QuantityNode)?.InnerText ?? "";
                        if (priceOrQuantityNode == null)
                        {
                            _stateMessages.Add(($"error_{_suppName}_{item.SelectSingleNode(_supplierXmlSetting.QuantityNode)} NOT FOUND in xml", "red"));
                        }
                    }

                    //if (!xmlModelPriceList.ContainsKey(model))
                    //{
                    xmlModelPriceList.TryAdd(model, priceOrQuantityNode);
                    //}
                }
            }
        }
        else
        {
            foreach (XmlNode item in itemsList)
            {
                string? model = null;

                if (_supplierXmlSetting.ParamAttribute == null)
                {
                    if (item.SelectSingleNode(_supplierXmlSetting.ModelNode) == null)
                    {
                        //_stateMessages.Add(($"error_{_suppName}_{_supplierXmlSetting.ModelNode}_{item.InnerText}_ NOT FOUND in xml", "red"));  // if xml item doesn`t exist code row 
                        continue;
                    }

                    model = item.SelectSingleNode(_supplierXmlSetting.ModelNode)?.InnerText ?? "";

                    if (String.IsNullOrEmpty(model))
                    {
                        _stateMessages.Add(($"error_{_suppName}_{item.SelectSingleNode(_supplierXmlSetting.ModelNode)}_ is Empty or Missing in xml", "red"));
                    }
                }
                else
                {
                    if (item.Attributes["id"] != null)
                    {
                        model = item.Attributes["id"]?.Value ?? "";
                        if (String.IsNullOrEmpty(model))
                        {
                            _stateMessages.Add(($"error_{_suppName}_{item.SelectSingleNode(_supplierXmlSetting.ModelNode)}_ is Empty or Missing in xml", "red"));
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                if (_currentTableDbColumnToUpdate == "Price")
                {
                    if (item.SelectSingleNode(_supplierXmlSetting.PriceNode) == null)
                    {
                        continue;
                    }
                    priceOrQuantityNode = item.SelectSingleNode(_supplierXmlSetting.PriceNode)?.InnerText ?? "";

                }
                else
                {
                    if (item.SelectSingleNode(_supplierXmlSetting.QuantityNode) == null)
                    {
                        continue;
                    }
                    priceOrQuantityNode = item.SelectSingleNode(_supplierXmlSetting.QuantityNode)?.InnerText ?? "";
                }

                xmlModelPriceList.TryAdd(model, priceOrQuantityNode);
            }

        }
    }

    private void GetExcelValues(string ftpHost, string ftpUser, string ftpPassword, string remoteFilePath, int modelColumnNumber, int priceQuantityColumn)
    {
        if (string.IsNullOrEmpty(ftpHost) || string.IsNullOrEmpty(ftpUser) || string.IsNullOrEmpty(ftpPassword))
        {
            //DirectoryInfo directory = new DirectoryInfo(_supplierXmlSetting.Path); FileInfo[] files = directory.GetFiles(); FileInfo newestfile = files.OrderByDescending(f => f.CreationTime).FirstOrDefault();

            if (remoteFilePath != null)
            {
                // Завантаження файлу з URL
                string localFilePath = Path.GetTempFileName();
                localFilePath = Path.ChangeExtension(localFilePath, "xlsx");
                string filePath = Uri.EscapeUriString(remoteFilePath);
                WebClient client = new();
                client.DownloadFile(filePath, localFilePath);

                using (var vb = new XLWorkbook(localFilePath))
                {
                    var worksheet = vb.Worksheet(1);

                    //int modelColumnNumber = GetColumnIndex(worksheet, 1, modelColumn);
                    //int priceQtyColumnNumber = GetColumnIndex(worksheet, 1, priceQuantityColumn);

                    string? model = null;
                    string? priceOrQuantityColumn = null;
                    xmlModelPriceList.Clear();

                    foreach (var row in worksheet.RowsUsed())
                    {
                        model = row.Cell(modelColumnNumber).Value.ToString() ?? "";
                        if (string.IsNullOrEmpty(model))
                        {
                            continue;
                        }

                        priceOrQuantityColumn = row.Cell(priceQuantityColumn).Value.ToString();

                        if (!xmlModelPriceList.TryAdd(model, priceOrQuantityColumn))
                            _stateMessages.Add(($"error_Duplicate model in excel file {_suppName} {model}", "red"));
                    }
                }
            }
            else
            {
                _stateMessages.Add(($"error_Excel file {_suppName} not found", "red"));
            }

        }
        else
        {
            // З'єднання з FTP для отримання списку файлів з екрануванням спецсиволів у імені файла
            string filePath = Uri.EscapeUriString(remoteFilePath);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri($"ftp://{ftpHost}/{filePath}"));
            request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new(responseStream);

            string[] files = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (files.Length > 0)
            {
                string? newestFileName = files
                    .Where(f => f.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(f => f).FirstOrDefault();

                if (!string.IsNullOrEmpty(newestFileName))
                {
                    // Завантаження найновішого файлу
                    WebClient ftpClient = new();
                    ftpClient.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                    ftpClient.DownloadFile($"ftp://{ftpHost}/{filePath}/{newestFileName}", newestFileName);

                    // Обробка файлу Excel
                    using (var vb = new XLWorkbook(newestFileName))
                    {
                        var vs = vb.Worksheet(1);

                        string? model = null;
                        string? priceOrQuantityColumn = null;
                        xmlModelPriceList.Clear();

                        foreach (var row in vs.RowsUsed())
                        {
                            model = row.Cell(_supplierXmlSetting.ModelXlColumn).Value.ToString() ?? "";
                            if (string.IsNullOrEmpty(model))
                            {
                                continue;
                            }

                            priceOrQuantityColumn = row.Cell(_supplierXmlSetting.PicturePriceQuantityXlColumn).Value.ToString();

                            if (!xmlModelPriceList.TryAdd(model, priceOrQuantityColumn))
                                _stateMessages.Add(($"error_Duplicate model in excel file {_suppName} {model}", "red"));
                        }
                    }

                    // Видаляємо завантажений файл
                    File.Delete(newestFileName);
                }
                else
                {
                    _stateMessages.Add(($"error_No Excel files found in {remoteFilePath}", "red"));
                }
            }
            else
            {
                _stateMessages.Add(($"error_No files found in {remoteFilePath}", "red"));
            }
        }

    }

    private void GetFeronQtyXlValues(string ftpHost, string ftpUser, string ftpPassword, string remoteFilePath, string? modelColumnNumber, string? priceQuantityColumn, string? boxColumn)
    {
        if (string.IsNullOrEmpty(ftpHost) || string.IsNullOrEmpty(ftpUser) || string.IsNullOrEmpty(ftpPassword))
        {
            //DirectoryInfo directory = new DirectoryInfo(_supplierXmlSetting.Path); FileInfo[] files = directory.GetFiles(); FileInfo newestfile = files.OrderByDescending(f => f.CreationTime).FirstOrDefault();

            if (remoteFilePath != null)
            {
                // Завантаження файлу з URL
                string localFilePath = Path.GetTempFileName();
                localFilePath = Path.ChangeExtension(localFilePath, "xlsx");
                string filePath = Uri.EscapeUriString(remoteFilePath);
                WebClient client = new();
                client.DownloadFile(filePath, localFilePath);

                using (var vb = new XLWorkbook(localFilePath))
                {
                    var worksheet = vb.Worksheet(1);

                    //int modelColumnNumber = GetColumnIndex(worksheet, 1, modelColumn);
                    //int priceQtyColumnNumber = GetColumnIndex(worksheet, 1, priceQuantityColumn);

                    string? model = null;
                    string? priceOrQuantityColumn = null;
                    string? unitsInBox = null;
                    xmlModelPriceList.Clear();

                    foreach (var row in worksheet.RowsUsed())
                    {
                        model = row.Cell(modelColumnNumber).Value.ToString() ?? "";
                        if (string.IsNullOrEmpty(model))
                        {
                            continue;
                        }

                        priceOrQuantityColumn = row.Cell(priceQuantityColumn).Value.ToString();
                        unitsInBox = row.Cell(boxColumn).Value.ToString();

                        if (priceOrQuantityColumn.Contains('>') & priceOrQuantityColumn.Contains("ящик"))
                        {
                            priceOrQuantityColumn = unitsInBox;
                        }


                        if (!xmlModelPriceList.TryAdd(model, priceOrQuantityColumn))
                            _stateMessages.Add(($"error_Duplicate model in excel file {_suppName} {model}", "red"));
                    }
                }
            }
            else
            {
                _stateMessages.Add(($"error_Excel file {_suppName} not found", "red"));
            }

        }
        else
        {
            // З'єднання з FTP для отримання списку файлів з екрануванням спецсиволів у імені файла
            string filePath = Uri.EscapeUriString(remoteFilePath);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri($"ftp://{ftpHost}/{filePath}"));
            request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new(responseStream);

            string[] files = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (files.Length > 0)
            {
                string? newestFileName = files
                    .Where(f => f.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(f => f).FirstOrDefault();

                if (!string.IsNullOrEmpty(newestFileName))
                {
                    // Завантаження найновішого файлу
                    WebClient ftpClient = new();
                    ftpClient.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                    ftpClient.DownloadFile($"ftp://{ftpHost}/{filePath}/{newestFileName}", newestFileName);

                    // Обробка файлу Excel
                    using (var vb = new XLWorkbook(newestFileName))
                    {
                        var vs = vb.Worksheet(1);

                        string? model = null;
                        string? priceOrQuantityColumn = null;
                        xmlModelPriceList.Clear();

                        foreach (var row in vs.RowsUsed())
                        {
                            model = row.Cell(_supplierXmlSetting.ModelXlColumn).Value.ToString() ?? "";
                            if (string.IsNullOrEmpty(model))
                            {
                                continue;
                            }

                            priceOrQuantityColumn = row.Cell(_supplierXmlSetting.PicturePriceQuantityXlColumn).Value.ToString();

                            if (!xmlModelPriceList.TryAdd(model, priceOrQuantityColumn))
                                _stateMessages.Add(($"error_Duplicate model in excel file {_suppName} {model}", "red"));
                        }
                    }

                    // Видаляємо завантажений файл
                    File.Delete(newestFileName);
                }
                else
                {
                    _stateMessages.Add(($"error_No Excel files found in {remoteFilePath}", "red"));
                }
            }
            else
            {
                _stateMessages.Add(($"error_No files found in {remoteFilePath}", "red"));
            }
        }
    }

    private void GetGammaQtyXmlValues()
    {
        XmlDocument xmlDoc = new();

        string priceOrQuantityNode = "";
        string model = "";
        xmlModelPriceList.Clear();

        xmlDoc.Load(_supplierXmlSetting.Path);

        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(_supplierXmlSetting.ProductNode);

        foreach (XmlNode item in itemsList)
        {
            if (_supplierXmlSetting.ParamAttribute == null)
            {
                if (item.SelectSingleNode(_supplierXmlSetting.ModelNode) == null)
                {
                    continue;
                }
                model = item.SelectSingleNode(_supplierXmlSetting.ModelNode)?.InnerText;
            }
            else
            {
                if (item.Attributes["id"] != null)
                {
                    model = item.Attributes["id"]?.Value;
                }
                else
                {
                    continue;
                }
            }

            int stock1 = 0;
            int stock2 = 0;
            int stock3 = 0;
            int stock4 = 0;
            int stock5 = 0;
            int stock6 = 0;
            int stock7 = 0;
            int stock8 = 0;
            int stock9 = 0;

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock1)?.InnerText, out stock1))
            {
                stock1 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock2)?.InnerText, out stock2))
            {
                stock2 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock3)?.InnerText, out stock3))
            {
                stock3 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock4)?.InnerText, out stock4))
            {
                stock4 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock5)?.InnerText, out stock5))
            {
                stock5 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock6)?.InnerText, out stock6))
            {
                stock6 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock7)?.InnerText, out stock7))
            {
                stock7 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock8)?.InnerText, out stock8))
            {
                stock8 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(_supplierXmlSetting.QuantityDbStock9)?.InnerText, out stock9))
            {
                stock9 = 0;
            }

            int aggregatedQuantity = stock1 + stock2 + stock3 + stock4 + stock5 + stock6 + stock7 + stock8 + stock9;

            priceOrQuantityNode = aggregatedQuantity.ToString();

            xmlModelPriceList.TryAdd(model, priceOrQuantityNode);
        }
    }

    #endregion


    private void UpdatePrices(List<(string, string, string, string)> dbCodeModelPriceList, Dictionary<string, string> xmlModelPriceList)
    {
        var skusToUpdate = dbCodeModelPriceList.Select(s => s.Item1).ToList();
        var manualPrice = _dbContextGamma.ProductsManualSetPrices.ToList();

        var productsListToUpdate = _dbContextGamma.NgProducts
            .Where(p => skusToUpdate.Contains(p.Sku))
            .Select(m => new ProductMinInfoModel
            {
                Sku = m.Sku,
                Model = m.Model,
                Price = m.Price,
                Quantity = m.Quantity
            })
            .ToList();

        foreach (var dbModel in dbCodeModelPriceList)
        {
            var productToUpdate = productsListToUpdate.FirstOrDefault(p => p.Sku == dbModel.Item1);

            if (manualPrice.Any(p => p.Sku == productToUpdate.Sku)) //ручне встановлення наявності.
            {
                var manualValue = manualPrice.FirstOrDefault(p => p.Sku == dbModel.Item1)?.SetInStockPrice ?? 0;

                productToUpdate.Price = manualValue;

                _stateMessages.Add(($"default_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{dbModel.Item4}_SetManually:_{manualValue} грн", "black"));
            }
            else
            {
                if (xmlModelPriceList.TryGetValue(dbModel.Item2, out var xmlValue) && dbModel.Item3 != xmlValue)
                {
                    decimal dbValue = 0;
                    decimal currentXmlValue = 0;

                    try
                    {
                        if (dbModel.Item3.Contains('.'))
                        {
                            dbValue = Convert.ToDecimal(dbModel.Item3.Replace('.', ','));
                        }
                        else
                        {
                            dbValue = Convert.ToDecimal(dbModel.Item3);
                        }

                        if (xmlValue.Contains('.'))
                        {
                            currentXmlValue = Convert.ToDecimal(xmlValue.Replace('.', ','));
                        }
                        else
                        {
                            currentXmlValue = Convert.ToDecimal(xmlValue);
                        }

                        if (_suppName == "Gamma" || _suppName == "Gamma-K")
                        {
                            currentXmlValue = (currentXmlValue + (currentXmlValue * 0.4m)) * 50m;
                        }


                        var normalizedDbValue = Math.Round(dbValue, 2);
                        var normalizedXmlValue = Math.Round(currentXmlValue, 2);

                        if (normalizedDbValue != normalizedXmlValue)
                        {
                            if (normalizedDbValue < normalizedXmlValue)
                            {
                                if (productToUpdate != null)
                                {
                                    productToUpdate.Price = normalizedXmlValue;
                                    _stateMessages.Add(($"+_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ price increased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                                }
                            }
                            else
                            {
                                //var productToUpdate = _dbContextGamma.NgProducts.FirstOrDefault(p => p.Sku == dbModel.Item1);
                                if (productToUpdate != null)
                                {
                                    productToUpdate.Price = normalizedXmlValue;

                                    _stateMessages.Add(($"-_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ price decreased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {

                        _stateMessages.Add(($"error_Error occurred while price of {_suppName}  updated. DB data: {dbModel.Item1} {dbModel.Item2} _{CutString(dbModel.Item4)} {dbModel.Item3}. XML data {xmlValue} ", "red"));
                    }
                }
                else
                {
                    _stateMessages.Add(($"error_{_suppName}_{dbModel.Item1}_{dbModel.Item2}_{dbModel.Item3}_{dbModel.Item4}_ NOT FOUND in xml", "red"));
                }
            }
        }
        _dbContextGamma.SaveChanges();
    }


    private void UpdateQuantity(List<(string, string, string, string)> dbCodeModelPriceList, Dictionary<string, string> xmlModelPriceList)
    {
        var skusToUpdate = dbCodeModelPriceList.Select(s => s.Item1).ToList();
        var manualQty = _dbContextGamma.ProductsManualSetQuanitys.Where(m => skusToUpdate.Contains(m.Sku)).ToList();
        var setMinQty = _dbContextGamma.ProductsSetQuantityWhenMin.Where(m => skusToUpdate.Contains(m.Sku)).ToList();

        var productsListToUpdate = _dbContextGamma.NgProducts.Where(p => skusToUpdate.Contains(p.Sku))
            .Select(p => new ProductMinInfoModel
            {
                Sku = p.Sku,
                Model = p.Model,
                Price = p.Price,
                Quantity = p.Quantity,
                StockStatusId = p.StockStatusId
            })
            .ToList();

        foreach (var dbModel in dbCodeModelPriceList)
        {
            try
            {
                var productToUpdate = productsListToUpdate.FirstOrDefault(p => p.Sku == dbModel.Item1);

                if (manualQty.Any(p => p.Sku == productToUpdate?.Sku)) //ручне встановлення наявності.
                {
                    var manualValue = manualQty.FirstOrDefault(p => p.Sku == dbModel.Item1)?.SetInStockQty ?? 0;

                    if (manualValue > 0)
                    {
                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = manualValue });
                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 7 });
                    }
                    else
                    {
                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = manualValue });
                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 5 });
                    }
                    _stateMessages.Add(($"manualValue_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ quantity set to default- {manualValue}. Old-_{dbModel.Item3}", "black"));
                }
                else
                {
                    #region Retieving xml value

                    int currentXmlValue = 0;
                    int? dbValue = 0;
                    if (xmlModelPriceList.TryGetValue(dbModel.Item2, out var xmlValue))
                    {
                        if (dbModel.Item3 != xmlValue)
                        {
                            if (dbModel.Item3.Contains('.'))
                            {
                                dbValue = Convert.ToInt32(dbModel.Item3.Replace('.', ','));
                            }
                            else
                            {
                                dbValue = Convert.ToInt32(dbModel.Item3);
                            }

                            if (xmlValue.Contains('.'))
                            {
                                currentXmlValue = Convert.ToInt32(xmlValue.Replace('.', ','));
                            }
                            else
                            {
                                currentXmlValue = Convert.ToInt32(xmlValue);
                            }
                        }

                        #endregion

                        var minQtylValue = setMinQty.FirstOrDefault(p => p.Sku == dbModel.Item1)?.MinQuantity ?? 0;
                        if (setMinQty.Any(p => p.Sku == productToUpdate.Sku && currentXmlValue < minQtylValue && currentXmlValue > 0)) // ручне встановлення мінімальних залишків
                        {
                            var setQtylValue = setMinQty.FirstOrDefault(p => p.Sku == dbModel.Item1)?.SetQuantity ?? 0;

                            if (setQtylValue > 0)
                            {
                                _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = currentXmlValue });
                                _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 7 });
                            }
                            else
                            {
                                _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = setQtylValue });
                                _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 5 });
                            }
                            _stateMessages.Add(($"setMin_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ quantity set to min: {setQtylValue}. Real xml was {currentXmlValue}. DB was:_{dbModel.Item3}", "yellow"));
                        }
                        else
                        {
                            if (dbValue != currentXmlValue)
                            {
                                if (dbValue < currentXmlValue)
                                {
                                    if (currentXmlValue > 0)
                                    {
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = currentXmlValue });
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 7 });

                                        _stateMessages.Add(($"+_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ quantity increased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                                    }
                                    else
                                    {
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = currentXmlValue });
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 5 });

                                        _stateMessages.Add(($"+_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ quantity increased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                                    }
                                }
                                else
                                {
                                    if (currentXmlValue > 0)
                                    {
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = currentXmlValue });
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 7 });

                                        _stateMessages.Add(($"-_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ quantity decreased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                                    }
                                    else
                                    {
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1)
                                            .Update(x => new NgProduct { Quantity = currentXmlValue });
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1)
                                            .Update(x => new NgProduct { StockStatusId = 5 });

                                        _stateMessages.Add(($"-_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ quantity decreased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        currentXmlValue = 0;
                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = currentXmlValue });
                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 5 });

                        _stateMessages.Add(($"set-0_{dbModel.Item1}_{dbModel.Item2}_{_suppName}_{CutString(dbModel.Item4)}_ NOT FOUND in XML. Set - 0. Old - new:_{dbModel.Item3}_{currentXmlValue}", "brown"));
                    }
                }
            }
            catch (Exception)
            {
                _stateMessages.Add(($"error_Something happened while quantity of {_suppName}  updated. Data NOT ADD to DB: {dbModel.Item1} {dbModel.Item2} {CutString(dbModel.Item4)} {dbModel.Item3}", "red"));
            }
        }
        _dbContextGamma.SaveChanges();
    }


    private static string CutString(string input)
    {
        const int maxLength = 70;

        if (input.Length > maxLength)
        {
            return input.Substring(0, maxLength - 3) + "...";
        }
        return input.PadRight(maxLength);
    }
}
