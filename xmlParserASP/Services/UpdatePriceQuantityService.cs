using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net;
using System.Xml;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services.UpdateServices;
using Z.EntityFramework.Plus;

namespace xmlParserASP.Services;

public class UpdatePriceQuantityService
{
    private readonly GammaContext _dbContextGamma;
    private readonly DataContainer _dc;


    public UpdatePriceQuantityService(MmSupplierXmlSetting supplierXmlSetting, GammaContext dbContextGamma, DataContainerSingleton dcS)
    {
        _dbContextGamma = dbContextGamma;
        _dc = dcS.Instance;
    }

    public async Task<List<(string, string)>> MasterUpdatePriceQtyClass(int settingsId, string tableDbColumnToUpdate)

    {
        if (_dc.SuppliersList.Count == 0)
        {
            _dc.SuppliersList = _dbContextGamma.MmSuppliers.ToList();
            _dc.SuppSettingList = _dbContextGamma.MmSupplierXmlSettings.ToList();
        }

        _dc.CurrentTableDbColumnToUpdate = tableDbColumnToUpdate;

        //_dc.StateMessages = new(); //it help to avoid messages duplicates, when called update price and quantity simultaneously

        //if (settingsId == null)
        //{
        //    _dc.StateMessages.Add(("Setting ID was not passed", "red"));
        //    return _dc.StateMessages;
        //}

        #region Get current values from DB and add them to new '_dc.DbCodeModelPriceList' on each iteration

        _dc.SupplierXmlSetting = _dc.SuppSettingList
            .Where(m => m.SupplierXmlSettingId == settingsId)
            .FirstOrDefault();

        if (_dc.SupplierXmlSetting == null)
        {
            _dc.StateMessages.Add(("1_Supplier setting was not found in DB", "red"));
            return _dc.StateMessages;
        }

        _dc.SuppName = (_dc.SuppliersList.FirstOrDefault(m =>
            m.SupplierId == _dc.SupplierXmlSetting.SupplierId))?.SupplierName;


        if (_dc.SuppNameThatWasUpdatedList != null && !_dc.SuppNameThatWasUpdatedList.Contains(_dc.SuppName))
        {
            _dc.CurrentSuppProductIDList = await _dbContextGamma.NgProductToSuppliers
        .Where(m => m.SupplierId == _dc.SuppName)
        .Select(m => m.ProductId)
        .ToListAsync();

            if (_dc.CurrentSuppProductIDList == null)
            {
                _dc.StateMessages.Add(($"1_Supplier {_dc.SuppName} has no one product in DB", "red"));
                return _dc.StateMessages;
            }


            _dc.Products = await _dbContextGamma.NgProducts
                .Where(p => _dc.CurrentSuppProductIDList.Contains(p.ProductId) && p.Status == true)
                .Select(m => new ProductMinInfoModel
                {
                    ProductId = m.ProductId,
                    Sku = m.Sku,
                    Model = m.Model,
                    Price = m.Price,
                    Quantity = m.Quantity
                }).ToListAsync();

            //todo: END this

            _dc.NamesOfProducts =
                await _dbContextGamma.NgProductDescriptions.Where(p => _dc.CurrentSuppProductIDList.Contains(p.ProductId))
                    .Where(n => n.LanguageId ==3)
                    .Select(p => new ProductNamesListModel
                    {
                        ProductId = p.ProductId,
                        ProductName = p.Name
                    }
                ).ToListAsync();

            foreach (var product in _dc.Products)
            {
                try
                {
                    var priceValue = product.Price.ToString();
                    var qtyValue = product.Quantity.ToString();
                    var productName = _dc.NamesOfProducts.FirstOrDefault(n => n.ProductId == product.ProductId)?.ProductName;

                    _dc.DbCodeModelPriceList.Add((product.Sku, product.Model, priceValue, qtyValue, productName));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing field {product.Sku} : {ex.Message}");
                }
            }
        }

        #endregion


        if ((_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K") & _dc.CurrentTableDbColumnToUpdate == "Quantity")
        {
            GetGammaQtyXmlValues();
        }
        else if (_dc.SuppName == "Kanlux")
        {
            if (_dc.CurrentTableDbColumnToUpdate == "Price" & _dc.SupplierXmlSetting.SettingName == "Kanlux_price_XL")
            {
                GetExcelValues("", "", "", _dc.SupplierXmlSetting.Path);
            }

            if (_dc.CurrentTableDbColumnToUpdate == "Quantity" & _dc.SupplierXmlSetting.SettingName == "Kanlux_qty_XL")
            {
                GetExcelValues("", "", "", _dc.SupplierXmlSetting.Path);
            }
        }
        else if (_dc.SuppName == "Feron")
        {
            if (_dc.CurrentTableDbColumnToUpdate == "Quantity" & _dc.SupplierXmlSetting.SettingName == "Feron_excel")
            {
                GetFeronQtyXlValues("", "", "", _dc.SupplierXmlSetting.Path, _dc.SupplierXmlSetting.ModelXlColumn,
                    _dc.SupplierXmlSetting.PicturePriceQuantityXlColumn, _dc.SupplierXmlSetting.QtyInBoxColumnNumber);
            }
        }
        else
        {
            GetXmlValues();
        }

        if (_dc.CurrentTableDbColumnToUpdate == "Price")
        {
            UpdatePrices();
        }
        else
        {
            UpdateQuantity();
        }

        _dc.SuppNameThatWasUpdatedList.Add(_dc.SuppName);
        _dc.StateMessages.Add(($"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} updated successful", "green"));


        var stateMessages = _dc.StateMessages.OrderBy(m => m.Item1).ToList();

        _dc.StateMessages.Clear();
        if (tableDbColumnToUpdate == "Quantity")
        {
            _dc.DbCodeModelPriceList.Clear();
            _dc.XmlModelPriceList.Clear();
            _dc.XmlModelQuantityList.Clear();
        }


        return stateMessages;
    }

    #region Get xml and excel values from all suppliers unloads and add it to '_dc.XmlModelPriceList or XmlModelQuantityList'

    private void GetXmlValues()
    {
        XmlDocument xmlDoc = new();

        string fileExtension = Path.GetExtension(_dc.SupplierXmlSetting.Path);
        string priceNode = "";
        string quantityNode = "";

        _dc.XmlModelPriceList.Clear();

        xmlDoc.Load(_dc.SupplierXmlSetting.Path);

        // xmlDoc.LoadXml(_dc.SupplierXmlSetting.Path);


        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(_dc.SupplierXmlSetting.ProductNode);

        if (_dc.SupplierXmlSetting.MainProductNode != null) //Main node we need to Proforma etc
        {
            XmlNodeList parentItemsList = xmlDoc.GetElementsByTagName(_dc.SupplierXmlSetting.MainProductNode);

            foreach (XmlNode items in parentItemsList)
            {
                foreach (XmlNode item in itemsList)
                {
                    string? model = null;

                    if (_dc.SupplierXmlSetting.ParamAttribute == null)
                    {
                        model = item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)?.InnerText;

                        if (String.IsNullOrEmpty(model))
                        {
                            _dc.StateMessages.Add((
                                $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)} NOT FOUND in xml",
                                "red"));
                        }
                    }
                    else
                    {
                        if (item.Attributes["id"] != null)
                        {
                            if (item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode) == null)
                            {
                                _dc.StateMessages.Add((
                                    $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)} NOT FOUND in xml",
                                    "red"));
                                continue;
                            }

                            model = item.Attributes["id"]?.Value;

                            if (String.IsNullOrEmpty(model))
                            {
                                _dc.StateMessages.Add((
                                    $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)} NOT FOUND in xml",
                                    "red"));
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (_dc.CurrentTableDbColumnToUpdate == "Price")
                    {
                        priceNode = item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)?.InnerText ?? "";
                        if (priceNode == null)
                        {
                            _dc.StateMessages.Add((
                                $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)} NOT FOUND in xml",
                                "red"));
                        }
                    }
                    else
                    {
                        quantityNode = item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode)?.InnerText ?? "";
                        if (quantityNode == null)
                        {
                            _dc.StateMessages.Add((
                                $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode)} NOT FOUND in xml",
                                "red"));
                        }
                    }

                    _dc.XmlModelPriceList.TryAdd(model, priceNode);
                    _dc.XmlModelQuantityList.TryAdd(model, quantityNode);
                }
            }
        }
        else
        {
            foreach (XmlNode item in itemsList)
            {
                string? model = null;

                if (_dc.SupplierXmlSetting.ParamAttribute == null)
                {
                    if (item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode) == null)
                    {
                        //_dc.StateMessages.Add(($"error_{_dc.SuppName}_{_dc.SupplierXmlSetting.ModelNode}_{item.InnerText}_ NOT FOUND in xml", "red"));  // if xml item doesn`t exist code row 
                        continue;
                    }

                    model = item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)?.InnerText ?? "";

                    if (String.IsNullOrEmpty(model))
                    {
                        _dc.StateMessages.Add((
                            $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)}_ is Empty or Missing in xml",
                            "red"));
                    }
                }
                else
                {
                    if (item.Attributes["id"] != null)
                    {
                        model = item.Attributes["id"]?.Value ?? "";
                        if (String.IsNullOrEmpty(model))
                        {
                            _dc.StateMessages.Add((
                                $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)}_ is Empty or Missing in xml",
                                "red"));
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                if (_dc.CurrentTableDbColumnToUpdate == "Price")
                {
                    priceNode = item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)?.InnerText ?? "";
                    if (priceNode == null)
                    {
                        _dc.StateMessages.Add((
                            $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)} NOT FOUND in xml",
                            "red"));
                    }
                    _dc.XmlModelPriceList.TryAdd(model, priceNode);
                }
                else if (_dc.CurrentTableDbColumnToUpdate == "Quantity")
                {
                    quantityNode = item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode)?.InnerText ?? "";
                    if (quantityNode == null)
                    {
                        _dc.StateMessages.Add((
                            $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode)} {_dc.CurrentTableDbColumnToUpdate} NOT FOUND in xml",
                            "red"));
                    }
                    _dc.XmlModelQuantityList.TryAdd(model, quantityNode);
                }
                else
                {
                    if (item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode) == null)
                    {
                        _dc.StateMessages.Add(($"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)} {_dc.CurrentTableDbColumnToUpdate} NOT FOUND in xml", "red"));
                    }
                    if (item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode) == null)
                    {
                        _dc.StateMessages.Add(($"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)}  {_dc.CurrentTableDbColumnToUpdate} NOT FOUND in xml", "red"));
                    }

                    priceNode = item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)?.InnerText ?? "";
                    quantityNode = item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode)?.InnerText ?? "";

                    _dc.XmlModelPriceList.TryAdd(model, priceNode);
                    _dc.XmlModelQuantityList.TryAdd(model, quantityNode);
                }
            }
        }
    }

    private void GetExcelValues(string ftpHost, string ftpUser, string ftpPassword, string remoteFilePath) //, int modelColumnNumber, int priceQuantityColumn
    {
        if (!int.TryParse(_dc.SupplierXmlSetting.ModelXlColumn, out var modelColumnNumber))
        {
            _dc.StateMessages.Add(($"1_{_dc.SuppName} model column number in excel file was not converted successful, model column set to 1",
                "red"));
            modelColumnNumber = 1;
        }

        if (!int.TryParse(_dc.SupplierXmlSetting.PicturePriceQuantityXlColumn, out var priceColumnNumber))
        {
            _dc.StateMessages.Add((
                $"1_{_dc.SuppName} price or quantity column number in excel file was not converted successful, price or quantity column set to 2",
                "red"));
            priceColumnNumber = 2;
        }
        if (string.IsNullOrEmpty(ftpHost) || string.IsNullOrEmpty(ftpUser) || string.IsNullOrEmpty(ftpPassword))
        {
            //DirectoryInfo directory = new DirectoryInfo(_dc.SupplierXmlSetting.Path); FileInfo[] files = directory.GetFiles(); FileInfo newestfile = files.OrderByDescending(f => f.CreationTime).FirstOrDefault();

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
                    _dc.XmlModelPriceList.Clear();

                    foreach (var row in worksheet.RowsUsed())
                    {
                        model = row.Cell(modelColumnNumber).Value.ToString() ?? "";
                        if (string.IsNullOrEmpty(model))
                        {
                            continue;
                        }

                        priceOrQuantityColumn = row.Cell(priceColumnNumber).Value.ToString();

                        if (!_dc.XmlModelPriceList.TryAdd(model, priceOrQuantityColumn))
                            _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));
                    }
                }
            }
            else
            {
                _dc.StateMessages.Add(($"error_Excel file {_dc.SuppName} not found", "red"));
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

            string[] files = reader.ReadToEnd()
                .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

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
                        _dc.XmlModelPriceList.Clear();

                        foreach (var row in vs.RowsUsed())
                        {
                            model = row.Cell(_dc.SupplierXmlSetting.ModelXlColumn).Value.ToString() ?? "";
                            if (string.IsNullOrEmpty(model))
                            {
                                continue;
                            }

                            priceOrQuantityColumn = row.Cell(_dc.SupplierXmlSetting.PicturePriceQuantityXlColumn).Value
                                .ToString();

                            if (!_dc.XmlModelPriceList.TryAdd(model, priceOrQuantityColumn))
                                _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));
                        }
                    }
                    // Видаляємо завантажений файл
                    File.Delete(newestFileName);
                }
                else
                {
                    _dc.StateMessages.Add(($"error_No Excel files found in {remoteFilePath}", "red"));
                }
            }
            else
            {
                _dc.StateMessages.Add(($"error_No files found in {remoteFilePath}", "red"));
            }
        }
    }

    private void GetFeronQtyXlValues(string ftpHost, string ftpUser, string ftpPassword, string remoteFilePath,
        string? modelColumnNumber, string? priceQuantityColumn, string? boxColumn)
    {
        if (string.IsNullOrEmpty(ftpHost) || string.IsNullOrEmpty(ftpUser) || string.IsNullOrEmpty(ftpPassword))
        {
            //DirectoryInfo directory = new DirectoryInfo(_dc.SupplierXmlSetting.Path); FileInfo[] files = directory.GetFiles(); FileInfo newestfile = files.OrderByDescending(f => f.CreationTime).FirstOrDefault();

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
                    _dc.XmlModelQuantityList.Clear();

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


                        if (!_dc.XmlModelQuantityList.TryAdd(model, priceOrQuantityColumn))
                            _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));
                    }
                }
            }
            else
            {
                _dc.StateMessages.Add(($"error_Excel file {_dc.SuppName} not found", "red"));
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

            string[] files = reader.ReadToEnd()
                .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

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
                        _dc.XmlModelQuantityList.Clear();

                        foreach (var row in vs.RowsUsed())
                        {
                            model = row.Cell(_dc.SupplierXmlSetting.ModelXlColumn).Value.ToString() ?? "";
                            if (string.IsNullOrEmpty(model))
                            {
                                continue;
                            }

                            priceOrQuantityColumn = row.Cell(_dc.SupplierXmlSetting.PicturePriceQuantityXlColumn).Value
                                .ToString();

                            if (!_dc.XmlModelQuantityList.TryAdd(model, priceOrQuantityColumn))
                                _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));
                        }
                    }

                    // Видаляємо завантажений файл
                    File.Delete(newestFileName);
                }
                else
                {
                    _dc.StateMessages.Add(($"error_No Excel files found in {remoteFilePath}", "red"));
                }
            }
            else
            {
                _dc.StateMessages.Add(($"error_No files found in {remoteFilePath}", "red"));
            }
        }
    }

    private void GetGammaQtyXmlValues()
    {
        XmlDocument xmlDoc = new();

        string quantityNode = "";
        string model = "";
        _dc.XmlModelQuantityList.Clear();

        xmlDoc.Load(_dc.SupplierXmlSetting.Path);

        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(_dc.SupplierXmlSetting.ProductNode);

        List<string?> xPaths = new() {
            _dc.SupplierXmlSetting.QuantityDbStock1,
            _dc.SupplierXmlSetting.QuantityDbStock2,
            _dc.SupplierXmlSetting.QuantityDbStock3,
            _dc.SupplierXmlSetting.QuantityDbStock4,
            _dc.SupplierXmlSetting.QuantityDbStock5,
            _dc.SupplierXmlSetting.QuantityDbStock6,
            _dc.SupplierXmlSetting.QuantityDbStock7,
            _dc.SupplierXmlSetting.QuantityDbStock8,
            _dc.SupplierXmlSetting.QuantityDbStock9
        };

        List<string> stocksList = xPaths.Where(x => x != null).ToList();

        foreach (XmlNode item in itemsList)
        {
            // get model
            if (_dc.SupplierXmlSetting.ParamAttribute == null)
            {
                if (item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode) == null)
                {
                    continue;
                }
                model = item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)?.InnerText;
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

            //get quantities from all stocks
            var quantities = stocksList
                .Select(stocksList => item.SelectSingleNode(stocksList)?.InnerText)
                .Select(value => value != null ? (int.TryParse(value, out int result) ? result : 0) : 0)
                .ToList();

            quantityNode = quantities.Sum().ToString();

            _dc.XmlModelQuantityList.TryAdd(model, quantityNode);
        }
    }

    #endregion


    private void UpdatePrices()
    {
        var skusToUpdate = _dc.DbCodeModelPriceList.Select(s => s.Item1).ToList();
        var manualPriceProductList = _dbContextGamma.ProductsManualSetPrices.Where(n => skusToUpdate.Contains(n.Sku)).ToList();

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

        foreach (var dbModel in _dc.DbCodeModelPriceList)
        {
            var productToUpdate = productsListToUpdate.FirstOrDefault(p => p.Sku == dbModel.Item1);

            if (manualPriceProductList.Any(p => p.Sku == productToUpdate.Sku)) //ручне встановлення наявності.
            {
                var manualValue = manualPriceProductList.FirstOrDefault(p => p.Sku == dbModel.Item1)?.SetInStockPrice ?? 0;

                if (decimal.TryParse(dbModel.Item3, out decimal currentDbManualPrice) && currentDbManualPrice != manualValue)  // remove this if tsatement, to see all manual prices added
                {
                    _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Price = manualValue });

                    _dc.StateMessages.Add(($"manualPrice_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{dbModel.Item5}_SetValue:_{manualValue} грн", "black"));
                }
            }
            else
            {
                if (_dc.XmlModelPriceList.TryGetValue(dbModel.Item2, out var xmlValue) && dbModel.Item3 != xmlValue)
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

                        if (_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K")
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
                                    _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Price = normalizedXmlValue });
                                    _dc.StateMessages.Add(($"+_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ price increased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                                }
                            }
                            else
                            {
                                if (productToUpdate != null)
                                {
                                    _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Price = normalizedXmlValue });
                                    _dc.StateMessages.Add(($"-_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ price decreased. Old - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {

                        _dc.StateMessages.Add(($"error_Error occurred while price of {_dc.SuppName}  updated. DB data: {dbModel.Item1} {dbModel.Item2} _{CutString(dbModel.Item5)} {dbModel.Item3}. XML data {xmlValue} ", "red"));
                    }
                }
                else
                {
                    _dc.StateMessages.Add(($"error_{_dc.SuppName}_{dbModel.Item1}_{dbModel.Item2}_{dbModel.Item3}_{dbModel.Item5}_ NOT FOUND in xml", "red"));
                }
            }
        }
        _dbContextGamma.SaveChanges();
    }


    private void UpdateQuantity()
    {
        var skusToUpdate = _dc.DbCodeModelPriceList.Select(s => s.Item1).ToList();
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

        foreach (var dbModel in _dc.DbCodeModelPriceList)
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
                    _dc.StateMessages.Add(($"manualValue_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity set to default- {manualValue}. Old-_{dbModel.Item4}", "black"));
                }
                else
                {
                    #region Retieving xml value

                    int currentXmlValue = 0;
                    int? dbValue = 0;
                    if (_dc.XmlModelQuantityList.TryGetValue(dbModel.Item2, out var xmlValue))
                    {
                        if (dbModel.Item4 != xmlValue)
                        {
                            if (dbModel.Item4.Contains('.'))
                            {
                                dbValue = Convert.ToInt32(dbModel.Item4.Replace('.', ','));
                            }
                            else
                            {
                                dbValue = Convert.ToInt32(dbModel.Item4);
                            }

                            if (xmlValue.Contains('.'))
                            {
                                currentXmlValue = Convert.ToInt32(xmlValue.Replace('.', ','));
                            }
                            else
                            {
                                currentXmlValue = Convert.ToInt32(xmlValue);
                            }

                            if (currentXmlValue < 0)
                            {
                                currentXmlValue = 0;
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
                            _dc.StateMessages.Add(($"setMin_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity set to min: {setQtylValue}. Real xml was {currentXmlValue}. DB was:_{dbModel.Item4}", "yellow"));
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

                                        _dc.StateMessages.Add(($"+_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity increased. Old - new:_{dbModel.Item4}_{currentXmlValue}", "purple"));
                                    }
                                    else
                                    {
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = currentXmlValue });
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 5 });

                                        _dc.StateMessages.Add(($"+_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity increased. Old - new:_{dbModel.Item4}_{currentXmlValue}", "purple"));
                                    }
                                }
                                else
                                {
                                    if (currentXmlValue > 0)
                                    {
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { Quantity = currentXmlValue });
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1).Update(x => new NgProduct { StockStatusId = 7 });

                                        _dc.StateMessages.Add(($"-_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity decreased. Old - new:_{dbModel.Item4}_{currentXmlValue}", "blue"));
                                    }
                                    else
                                    {
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1)
                                            .Update(x => new NgProduct { Quantity = currentXmlValue });
                                        _dbContextGamma.NgProducts.Where(x => x.Sku == dbModel.Item1)
                                            .Update(x => new NgProduct { StockStatusId = 5 });

                                        _dc.StateMessages.Add(($"-_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity decreased. Old - new:_{dbModel.Item4}_{currentXmlValue}", "blue"));
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

                        _dc.StateMessages.Add(($"set-0_{dbModel.Item1}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ NOT FOUND in XML. Set - 0. Old - new:_{dbModel.Item4}_{currentXmlValue}", "brown"));
                    }
                }
            }
            catch (Exception)
            {
                _dc.StateMessages.Add(($"error_Something happened while quantity of {_dc.SuppName}  updated. Data NOT ADD to DB: {dbModel.Item1} {dbModel.Item2} {CutString(dbModel.Item5)} {dbModel.Item4}", "red"));
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
