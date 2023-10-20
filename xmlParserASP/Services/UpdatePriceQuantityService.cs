using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using xmlParserASP.Controllers;
using xmlParserASP.Entities;
using xmlParserASP.Entities.TestGamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services;

public class UpdatePriceQuantityService
{
    private readonly SupplierXmlSetting _supplierXmlSetting;
    private readonly MyDBContext _dbContext;
    private readonly GammaContext _dbContextGamma;
    private readonly TestGammaDBContext _dbContextTestGamma;
    private SupplierXmlSetting? suppSettings;
    private string? suppName;
    private List<(string, string)>? stateMessages;
    private string currentTableDbColumnToUpdate = "";
    Dictionary<string, string> xmlModelPriceList = new();

    public UpdatePriceQuantityService(SupplierXmlSetting supplierXmlSetting, MyDBContext myDBContext, TestGammaDBContext dbContextTestGamma, GammaContext dbContextGamma)
    {
        _supplierXmlSetting = supplierXmlSetting;
        _dbContext = myDBContext;
        _dbContextTestGamma = dbContextTestGamma;
        _dbContextGamma=dbContextGamma;
    }

    public async Task<List<(string, string)>> MasterUpdatePriceQtyClass(List<int> settingsId, string tableDbColumnToUpdate)
    {
        currentTableDbColumnToUpdate = tableDbColumnToUpdate;

        stateMessages = new List<(string, string)>();
        

        if (settingsId == null)
        {
            stateMessages.Add(("Setting ID was not passed", "red"));
            return stateMessages;
        }

        foreach (int id in settingsId)
        {
            #region Получение текущих значений из БД

            suppSettings = await _dbContext.SupplierXmlSettings
                .Where(m => m.SupplierXmlSettingId == id)
                .FirstOrDefaultAsync();
            if (suppSettings == null)
            {
                stateMessages.Add(("Supplier setting was not found in DB", "red"));
                continue;
            }

            suppName = (await _dbContext.Suppliers.FirstOrDefaultAsync(m => m.SupplierId == suppSettings.SupplierId))?.SupplierName;

            if (suppName == null)
            {
                stateMessages.Add(("Supplier name was not found in DB", "red"));
                continue;
            }

            var currentSuppProductsList = await _dbContextGamma.OcProductToSuppliers
                .Where(m => m.SupplierId == suppName)
                .Select(m => m.ProductId)
                .ToListAsync();

            if (currentSuppProductsList == null)
            {
                stateMessages.Add(($"Supplier {suppName} has no one product in DB", "red"));
                continue;
            }

            var products = await _dbContextGamma.OcProducts
                .Where(p => currentSuppProductsList.Contains(p.ProductId))
                .ToListAsync();

            List<(string, string, string, string)> dbCodeModelPriceList = new();

            string priceQuantityValue = "";
            string productName = "";

            foreach (var product in products)
            {
                try
                {
                    if (currentTableDbColumnToUpdate == "Price")
                    {
                        priceQuantityValue = product.Price.ToString(CultureInfo.CurrentCulture);
                        productName = _dbContextGamma.OcProductDescriptions.Where(n => n.ProductId == product.ProductId).Select(m => m.Name).FirstOrDefault();
                    }
                    else
                    {
                        priceQuantityValue = product.Quantity.ToString();
                        productName = _dbContextGamma.OcProductDescriptions.Where(n => n.ProductId == product.ProductId).Select(m => m.Name).FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error processing field {product.Sku} : {ex.Message}");
                }

                dbCodeModelPriceList.Add((product.Sku, product.Model, priceQuantityValue, productName));
            }
            #endregion




            if ((suppName == "Gamma" || suppName == "Gamma-K") & currentTableDbColumnToUpdate == "Quantity")
            {
                GetGammaQuantityXmlValues();
            }
            else if (suppName == "Kanlux")
            {
                int modelColumnNumber;
                if (!int.TryParse(suppSettings.ModelXlColumn, out modelColumnNumber))
                {
                    stateMessages.Add(($"{suppName} model column number in excel file was not converted successful, model column set to 1", "red"));
                    modelColumnNumber = 1;
                }

                int priceColumnNumber;
                if (!int.TryParse(suppSettings.PicturePriceQuantityXlColumn, out priceColumnNumber))
                {
                    stateMessages.Add(($"{suppName} price or quantity column number in excel file was not converted successful, price or quantity column set to 2", "red"));
                    priceColumnNumber = 2;
                }


                if (currentTableDbColumnToUpdate == "Price" & suppSettings.SettingName == "Kanlux_price_XL")
                {
                    GetExcelValues("", "", "", suppSettings.Path, modelColumnNumber, priceColumnNumber);
                }

                if (currentTableDbColumnToUpdate == "Quantity" & suppSettings.SettingName == "Kanlux_qty_XL")
                {
                    GetExcelValues("", "", "", suppSettings.Path, modelColumnNumber, priceColumnNumber);
                }
            }
            else
            {
                GetXmlValues();
            }

            if (currentTableDbColumnToUpdate == "Price")
            {
                UpdatePrices(dbCodeModelPriceList, xmlModelPriceList);
            }
            else
            {
                UpdateQuantity(dbCodeModelPriceList, xmlModelPriceList);
            }

            stateMessages.Add(($"{suppName} {currentTableDbColumnToUpdate} updated successful", "green"));

        }
        return stateMessages;
    }

    private void GetXmlValues()
    {
        XmlDocument xmlDoc = new();

        string fileExtension = Path.GetExtension(suppSettings.Path);
        string priceOrQuantityNode = "";

        xmlModelPriceList.Clear();

        //if (fileExtension == ".xml")
        //{
        xmlDoc.Load(suppSettings.Path);
        //}
        //else
        //{
        //    xmlDoc.LoadXml(suppSettings.Path);
        //}

        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(suppSettings.ProductNode);

        if (suppSettings.MainProductNode != null)
        {
            XmlNodeList parentItemsList = xmlDoc.GetElementsByTagName(suppSettings.MainProductNode);

            foreach (XmlNode items in parentItemsList)
            {
                foreach (XmlNode item in itemsList)
                {
                    string? model = null;

                    if (suppSettings.paramAttribute == null)
                    {
                        model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText;

                        if (String.IsNullOrEmpty(model))
                        {
                            stateMessages.Add(($"{suppName}_{item.SelectSingleNode(suppSettings.ModelNode)} NOT FOUND in xml", "red"));
                        }
                    }
                    else
                    {
                        if (item.Attributes["id"] != null)
                        {
                            if (item.SelectSingleNode(suppSettings.ModelNode) == null)
                            {
                                stateMessages.Add(($"{suppName}_{item.SelectSingleNode(suppSettings.ModelNode)} NOT FOUND in xml", "red"));
                                continue;
                            }

                            model = item.Attributes["id"]?.Value;

                            if (String.IsNullOrEmpty(model))
                            {
                                stateMessages.Add(($"{suppName}_{item.SelectSingleNode(suppSettings.ModelNode)} NOT FOUND in xml", "red"));
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (currentTableDbColumnToUpdate == "Price")
                    {
                        priceOrQuantityNode = item.SelectSingleNode(suppSettings.PriceNode)?.InnerText ?? "";
                        if (priceOrQuantityNode == null)
                        {
                            stateMessages.Add(($"{suppName}_{item.SelectSingleNode(suppSettings.PriceNode)} NOT FOUND in xml", "red"));
                        }
                    }
                    else
                    {
                        priceOrQuantityNode = item.SelectSingleNode(suppSettings.QuantityNode)?.InnerText ?? "";
                        if (priceOrQuantityNode == null)
                        {
                            stateMessages.Add(($"{suppName}_{item.SelectSingleNode(suppSettings.QuantityNode)} NOT FOUND in xml", "red"));
                        }
                    }

                    if (!xmlModelPriceList.ContainsKey(model))
                    {
                        xmlModelPriceList.Add(model, priceOrQuantityNode);
                    }
                }
            }
        }
        else
        {
            foreach (XmlNode item in itemsList)
            {
                string? model = null;

                if (suppSettings.paramAttribute == null)
                {
                    if (item.SelectSingleNode(suppSettings.ModelNode) == null)
                    {
                        //stateMessages.Add(($"{suppName}_{suppSettings.ModelNode} NOT FOUND in xml1", "red"));
                        continue;
                    }

                    model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText ?? "";

                    if (String.IsNullOrEmpty(model))
                    {
                        stateMessages.Add(($"{suppName}_{item.SelectSingleNode(suppSettings.ModelNode)} is Empty or Missing in xml", "red"));
                    }
                }
                else
                {
                    if (item.Attributes["id"] != null)
                    {
                        model = item.Attributes["id"]?.Value ?? "";
                        if (String.IsNullOrEmpty(model))
                        {
                            stateMessages.Add(($"{suppName}_{item.SelectSingleNode(suppSettings.ModelNode)} is Empty or Missing in xml", "red"));
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                if (currentTableDbColumnToUpdate == "Price")
                {
                    if (item.SelectSingleNode(suppSettings.PriceNode) == null)
                    {
                        continue;
                    }
                    priceOrQuantityNode = item.SelectSingleNode(suppSettings.PriceNode)?.InnerText ?? "";

                }
                else
                {
                    if (item.SelectSingleNode(suppSettings.QuantityNode) == null)
                    {
                        continue;
                    }
                    priceOrQuantityNode = item.SelectSingleNode(suppSettings.QuantityNode)?.InnerText ?? "";
                }


                if (!xmlModelPriceList.ContainsKey(model))
                {
                    xmlModelPriceList.Add(model, priceOrQuantityNode);
                }
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

                        if (!xmlModelPriceList.ContainsKey(model))
                        {
                            xmlModelPriceList.Add(model, priceOrQuantityColumn);
                        }
                        else
                        {
                            stateMessages.Add(($"Duplicate model in excel file {suppName} {model}", "red"));
                        }
                    }
                }
            }
            else
            {
                stateMessages.Add(($"Excel file {suppName} not found", "red"));
            }

        }
        else
        {
            // З'єднання з FTP для отримання списку файлів
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri($"ftp://{ftpHost}/{remoteFilePath}"));
            request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string[] files = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (files.Length > 0)
            {
                string? newestFileName = files
                    .Where(f => f.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(f => f).FirstOrDefault();

                if (!string.IsNullOrEmpty(newestFileName))
                {
                    // Завантаження найновішого файлу
                    WebClient ftpClient = new WebClient();
                    ftpClient.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                    ftpClient.DownloadFile($"ftp://{ftpHost}/{remoteFilePath}/{newestFileName}", newestFileName);

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

                            if (!xmlModelPriceList.ContainsKey(model))
                            {
                                xmlModelPriceList.Add(model, priceOrQuantityColumn);
                            }
                            else
                            {
                                stateMessages.Add(($"Duplicate model in excel file {suppName} {model}", "red"));
                            }
                        }
                    }

                    // Видаляємо завантажений файл
                    File.Delete(newestFileName);
                }
                else
                {
                    stateMessages.Add(($"No Excel files found in {remoteFilePath}", "red"));
                }
            }
            else
            {
                stateMessages.Add(($"No files found in {remoteFilePath}", "red"));
            }
        }

    }


    private void GetGammaQuantityXmlValues()
    {
        XmlDocument xmlDoc = new();

        string priceOrQuantityNode = "";
        string model = "";
        xmlModelPriceList.Clear();

        xmlDoc.Load(suppSettings.Path);

        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(suppSettings.ProductNode);


        foreach (XmlNode item in itemsList)
        {
            if (suppSettings.paramAttribute == null)
            {
                if (item.SelectSingleNode(suppSettings.ModelNode) == null)
                {
                    continue;
                }
                model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText;
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

            if (!int.TryParse(item.SelectSingleNode(suppSettings.QuantityDBStock1)?.InnerText, out stock1))
            {
                stock1 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(suppSettings.QuantityDBStock2)?.InnerText, out stock2))
            {
                stock2 = 0;
            }

            if (!int.TryParse(item.SelectSingleNode(suppSettings.QuantityDBStock3)?.InnerText, out stock3))
            {
                stock3 = 0;
            }

            int aggregatedQuantity = stock1 + stock2 + stock3;

            priceOrQuantityNode = aggregatedQuantity.ToString();

            if (!xmlModelPriceList.ContainsKey(model))
            {
                xmlModelPriceList.Add(model, priceOrQuantityNode);
            }
        }
    }


    private void UpdatePrices(List<(string, string, string, string)> dbCodeModelPriceList, Dictionary<string, string> xmlModelPriceList)
    {
        foreach (var dbModel in dbCodeModelPriceList)
        {

            if (xmlModelPriceList.TryGetValue(dbModel.Item2, out var xmlValue) && dbModel.Item3 != xmlValue)
            {
                decimal dbValue = 0;
                decimal currentXmlValue = 0;

                try
                {
                    if (dbModel.Item3.Contains("."))
                    {
                        dbValue = Convert.ToDecimal(dbModel.Item3.Replace(".", ","));
                    }
                    else
                    {
                        dbValue = Convert.ToDecimal(dbModel.Item3);
                    }

                    if (xmlValue.Contains("."))
                    {
                        currentXmlValue = Convert.ToDecimal(xmlValue.Replace(".", ","));
                    }
                    else
                    {
                        currentXmlValue = Convert.ToDecimal(xmlValue);
                    }

                    if (suppName == "Gamma" || suppName == "Gamma-K")
                    {
                        currentXmlValue = (currentXmlValue + (currentXmlValue * 0.4m)) * 50m;
                    }


                    var normalizedDbValue = Math.Round(dbValue, 2);
                    var normalizedXmlValue = Math.Round(currentXmlValue, 2);

                    if (normalizedDbValue != normalizedXmlValue)
                    {
                        if (normalizedDbValue < normalizedXmlValue)
                        {
                            var productToUpdate = _dbContextGamma.OcProducts.FirstOrDefault(p => p.Sku == dbModel.Item1);
                            if (productToUpdate != null)
                            {
                                productToUpdate.Price = normalizedXmlValue;
                                stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{CutString(dbModel.Item4)}_ price increased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                            }
                        }
                        else
                        {
                            var productToUpdate = _dbContextGamma.OcProducts.FirstOrDefault(p => p.Sku == dbModel.Item1);
                            if (productToUpdate != null)
                            {
                                productToUpdate.Price = normalizedXmlValue;

                                stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{CutString(dbModel.Item4)}_ price decreased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    stateMessages.Add(($"Error occurred while price of {suppName}  updated. DB data: {dbModel.Item1} {dbModel.Item2} _{CutString(dbModel.Item4)} {dbModel.Item3}. XML data {xmlValue} ", "red"));
                }
            }
            else
            {
                stateMessages.Add(($"{suppName}_{dbModel.Item1}_{dbModel.Item2}_{dbModel.Item3}_{dbModel.Item4}_ NOT FOUND in xml", "red"));
            }
        }
        _dbContextGamma.SaveChanges();
    }


    private void UpdateQuantity(List<(string, string, string, string)> dbCodeModelPriceList, Dictionary<string, string> xmlModelPriceList)
    {
        foreach (var dbModel in dbCodeModelPriceList)
        {

            if (xmlModelPriceList.TryGetValue(dbModel.Item2, out var xmlValue) && dbModel.Item3 != xmlValue)
            {
                int dbValue = 0;
                int currentXmlValue = 0;

                try
                {
                    if (dbModel.Item3.Contains("."))
                    {
                        dbValue = Convert.ToInt32(dbModel.Item3.Replace(".", ","));
                    }
                    else
                    {
                        dbValue = Convert.ToInt32(dbModel.Item3);
                    }

                    if (xmlValue.Contains("."))
                    {
                        currentXmlValue = Convert.ToInt32(xmlValue.Replace(".", ","));
                    }
                    else
                    {
                        currentXmlValue = Convert.ToInt32(xmlValue);
                    }

                    if (dbValue != currentXmlValue)
                    {
                        if (dbValue < currentXmlValue)
                        {
                            var productToUpdate = _dbContextGamma.OcProducts.FirstOrDefault(p => p.Sku == dbModel.Item1);
                            
                            if (productToUpdate != null)
                            {
                                //if(_dbContextGamma.ProductsManualSetQuanitys.Any(p => p.Sku == productToUpdate.Sku))
                                if(currentXmlValue > 0)
                                {
                                    productToUpdate.Quantity = currentXmlValue;
                                    productToUpdate.StockStatusId = 7;
                                    stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{CutString(dbModel.Item4)}_ quantity increased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                                }
                                else
                                {
                                    productToUpdate.Quantity = currentXmlValue;
                                    productToUpdate.StockStatusId = 5;
                                    stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{CutString(dbModel.Item4)}_ quantity increased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                                }                                
                            }
                        }
                        else
                        {
                            var productToUpdate = _dbContextGamma.OcProducts.FirstOrDefault(p => p.Sku == dbModel.Item1);
                            if (productToUpdate != null)                            {
                                if (currentXmlValue > 0)
                                {
                                    productToUpdate.Quantity = currentXmlValue;
                                    productToUpdate.StockStatusId = 7;
                                    stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{CutString(dbModel.Item4)}_ quantity decreased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                                }
                                else
                                {
                                    productToUpdate.Quantity = currentXmlValue;
                                    productToUpdate.StockStatusId = 5;
                                    stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{CutString(dbModel.Item4)}_ quantity decreased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                                }                                
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    stateMessages.Add(($"Error occurred while quantity of {suppName}  updated. DB data: {dbModel.Item1} {dbModel.Item2} {CutString(dbModel.Item4)} {dbModel.Item3}. XML data {xmlValue} ", "red"));
                }
            }
        }
        _dbContextGamma.SaveChanges();
    }


    private string CutString(string input)
    {
        const int maxLength = 60;

        if (input.Length > maxLength)
        {
            return input.Substring(0, maxLength - 3) + "...";
        }
        else
        {
            return input.PadRight(maxLength);
        }
    }

    private int GetColumnIndex(IXLWorksheet worksheet, int rowWithNames, string columnName)
    {
        if (rowWithNames == null)
            rowWithNames = 1;

        int columnIndex = 1;

        while (worksheet.Cell(rowWithNames, columnIndex).Value.ToString() != columnName)
        {
            columnIndex++;
        }

        return columnIndex;
    }
}
