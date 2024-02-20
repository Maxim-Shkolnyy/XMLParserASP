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

    public UpdatePriceQuantityService(GammaContext dbContextGamma, DataContainerSingleton dcS)
    {
        _dbContextGamma = dbContextGamma;
        _dc = dcS.Instance;
    }

    public async Task<List<(string, string)>> MasterUpdatePriceQty(int settingsId)
    {
        if (_dc.SuppliersList.Count == 0)
        {
            _dc.SuppliersList = _dbContextGamma.MmSuppliers.ToList();
            _dc.SuppSettingList = _dbContextGamma.MmSupplierXmlSettings.ToList();
        }

        #region Get current values from DB and add them to new '_dc.DbCodeModelPriceList' on each iteration

        _dc.SupplierXmlSetting = _dc.SuppSettingList
            .FirstOrDefault(m => m.SupplierXmlSettingId == settingsId);

        if (_dc.SupplierXmlSetting == null)
        {
            _dc.StateMessages.Add(("1_Supplier setting was not found in DB", "red"));
            return _dc.StateMessages;
        }

        _dc.SuppName = (_dc.SuppliersList.FirstOrDefault(m =>
            m.SupplierId == _dc.SupplierXmlSetting.SupplierId))?.SupplierName;


        if (_dc.DbCodeModelPriceList.Count == 0)
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
                await _dbContextGamma.NgProductDescriptions.Where(p => _dc.Products.Select(id => id.ProductId).Contains(p.ProductId))
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
                    decimal priceValue = product.Price;
                    int qtyValue = product.Quantity;
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
                GetExcelValues("", "", "");
            }

            if (_dc.CurrentTableDbColumnToUpdate == "Quantity" & _dc.SupplierXmlSetting.SettingName == "Kanlux_qty_XL")
            {
                GetExcelValues("", "", "");
            }
        }
        else if (_dc.SupplierXmlSetting.SettingName == "Feron_excel")
        {
            GetExcelValues("", "", "");
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

        return stateMessages;
    }

    #region Get xml and excel values from all suppliers unloads and add it to '_dc.XmlModelPriceList or XmlModelQuantityList'

    private void GetXmlValues()
    {
        if (_dc.WhatToUpdate == 3 & _dc.SuppNameThatWasUpdatedList.Contains(_dc.SuppName) & _dc.CurrentTableDbColumnToUpdate == "Quantity")
        {
            return;
        }
        XmlDocument xmlDoc = new();

        _dc.XmlModelPriceList.Clear();

        xmlDoc.Load(_dc.SupplierXmlSetting.Path);

        // xmlDoc.LoadXml(_dc.SupplierXmlSetting.Path);


        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(_dc.SupplierXmlSetting.ProductNode);

        string? model;
        string priceStr;
        decimal price;

        foreach (XmlNode item in itemsList)
        {
            if (_dc.SupplierXmlSetting.ParamAttribute == null)
            {
                model = item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)?.InnerText ?? "";

                if (string.IsNullOrEmpty(model))
                {
                    //uncomment to see all nodes, that don`t have model  
                    //_dc.StateMessages.Add(($"no model in current xml node {_dc.SuppName}_{_dc.SupplierXmlSetting.ModelNode}_{item.InnerText}_{_dc.CurrentTableDbColumnToUpdate}_ NOT FOUND in xml", "red"));  // if xml item doesn`t exist code row 
                    continue;
                }
            }
            else
            {
                if (item.Attributes["id"] != null)
                {
                    model = item.Attributes["id"]?.Value;
                    if (String.IsNullOrEmpty(model))
                    {
                        _dc.StateMessages.Add(($"error_model {_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.ModelNode)}_ is Empty or Missing in xml", "red"));
                    }
                }
                else
                {
                    continue;
                }
            }

            if (_dc.WhatToUpdate == 1)
            {
                priceStr = item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)?.InnerText?? "";
                if (priceStr.Contains('.'))
                {
                    priceStr = priceStr.Replace(".", ",");
                }

                if (!decimal.TryParse(priceStr, out price))
                {
                    _dc.StateMessages.Add(($"error_price {_dc.SuppName}_{model} {_dc.CurrentTableDbColumnToUpdate} NOT converted to number correct", "red"));
                    continue;
                }

                if (price == 0)
                {
                    //uncomment string below to see all zero prices 
                    //_dc.StateMessages.Add(($"error_ price {_dc.SuppName}_{model} {_dc.CurrentTableDbColumnToUpdate} not updated, was 0 in xml", "red"));
                    continue;
                }

                _dc.XmlModelPriceList.TryAdd(model, price);
            }

            if (_dc.WhatToUpdate == 2)
            {
                if (_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K")
                {


                    //_dc.XmlModelQuantityList.TryAdd(model, quantity);
                }
                else
                {
                    if (!int.TryParse(item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode)?.InnerText,
                            out int quantity))
                    {
                        _dc.StateMessages.Add((
                            $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)} {model} {_dc.CurrentTableDbColumnToUpdate} NOT converted to number correct",
                            "red"));
                    }
                    else
                    {
                        _dc.XmlModelQuantityList.TryAdd(model, quantity);
                    }
                }
            }

            if (_dc.WhatToUpdate == 3)
            {
                priceStr = item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)?.InnerText?? "";

                if (priceStr.Contains('.'))
                {
                    priceStr = priceStr.Replace(".", ",");
                }

                if (!decimal.TryParse(priceStr, out price))
                {
                    _dc.StateMessages.Add(($"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)} {model} {_dc.CurrentTableDbColumnToUpdate} NOT converted to number correct", "red"));
                }

                if (price == 0)
                {
                    //uncomment string below to see all zero prices 
                    _dc.StateMessages.Add(($"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)} {_dc.CurrentTableDbColumnToUpdate} not updated, was 0 in xml", "red"));

                }
                else
                {
                    _dc.XmlModelPriceList.TryAdd(model, price);
                }

                if (_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K")
                {


                    //_dc.XmlModelQuantityList.TryAdd(model, quantity);
                }
                else
                {
                    if (!int.TryParse(item.SelectSingleNode(_dc.SupplierXmlSetting.QuantityNode)?.InnerText,
                            out int quantity))
                    {
                        _dc.StateMessages.Add((
                            $"error_{_dc.SuppName}_{item.SelectSingleNode(_dc.SupplierXmlSetting.PriceNode)} {model} {_dc.CurrentTableDbColumnToUpdate} NOT converted to number correct",
                            "red"));
                    }
                    else
                    {
                        _dc.XmlModelQuantityList.TryAdd(model, quantity);
                    }
                }
            }
        }
    }


    private void GetExcelValues(string ftpHost, string ftpUser, string ftpPassword)
    {
        string? remoteFilePath = _dc.SupplierXmlSetting.Path;
        if (remoteFilePath == null)
        {
            _dc.StateMessages.Add(($"Error_Excel file {_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} not found", "red"));
            return;
        }

        if (_dc.CurrentTableDbColumnToUpdate == "Quantity" &
            _dc.WhatToUpdate == 3 & _dc.XmlModelQuantityList.Count > 0)
        {
            return;
        }

        string? modelColumnNumber = _dc.SupplierXmlSetting.ModelXlColumn;
        string? priceColumn = _dc.SupplierXmlSetting.PricePictureXlColumn;

        string? quantityColumn = _dc.SupplierXmlSetting.QuantityXlColumn;
        string? boxColumn = _dc.SupplierXmlSetting.QtyInBoxColumnNumber;
        string localFilePath = Path.GetTempFileName();
        localFilePath = Path.ChangeExtension(localFilePath, "xlsx");

        string filePath = Uri.EscapeUriString(remoteFilePath);

        if (string.IsNullOrEmpty(ftpHost) || string.IsNullOrEmpty(ftpUser) || string.IsNullOrEmpty(ftpPassword))
        {
            WebClient client = new();
            client.DownloadFile(filePath, localFilePath);
        }
        else
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri($"ftp://{ftpHost}/{filePath}"));
            request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new(responseStream);

            string[] files = reader.ReadToEnd()
                .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //DirectoryInfo directory = new DirectoryInfo(_dc.SupplierXmlSetting.Path); FileInfo[] files = directory.GetFiles(); FileInfo newestfile = files.OrderByDescending(searchValueinXml => searchValueinXml.CreationTime).FirstOrDefault();

            if (files.Length > 0)
            {
                string? newestFileName = files
                    .Where(f => f.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(f => f).FirstOrDefault();

                if (!string.IsNullOrEmpty(newestFileName))
                {
                    WebClient ftpClient = new();
                    ftpClient.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                    ftpClient.DownloadFile($"ftp://{ftpHost}/{filePath}/{newestFileName}", newestFileName);
                }
            }
        }

        using (var vb = new XLWorkbook(localFilePath))
        {
            var worksheet = vb.Worksheet(1);

            string? model = "";
            string quantity = "";
            decimal price = 0;
            string? unitsInBox = "";

            _dc.XmlModelQuantityList.Clear();

            foreach (var row in worksheet.RowsUsed())
            {
                model = row.Cell(modelColumnNumber).Value.ToString() ?? "";
                if (string.IsNullOrEmpty(model))
                {
                    continue;
                }

                if (_dc.WhatToUpdate == 1)
                {
                    if (row.Cell(priceColumn).DataType == XLDataType.Number)
                    {
                        price = row.Cell(priceColumn).GetValue<decimal>();
                    }
                    else
                    {
                        continue;
                    }

                    if (!_dc.XmlModelPriceList.TryAdd(model, price)) _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));

                    continue;
                }

                if (_dc.WhatToUpdate == 2)
                {
                    quantity = row.Cell(quantityColumn).Value.ToString() ?? "";

                    if (_dc.SupplierXmlSetting.SettingName == "Feron_excel")
                    {
                        unitsInBox = row.Cell(boxColumn).Value.ToString();


                        if (quantity.Contains('>') & quantity.Contains("ящик"))
                        {
                            quantity = unitsInBox;
                        }
                    }

                    int.TryParse(quantity, out var qty);

                    if (!_dc.XmlModelQuantityList.TryAdd(model, qty))
                        _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));

                    continue;
                }

                if (_dc.WhatToUpdate == 3 && _dc.XmlModelPriceList.Count == 0)  //only if XmlModelPriceList not filled, we try to take new values
                {
                    if (row.Cell(priceColumn).DataType == XLDataType.Number)
                    {
                        price = row.Cell(priceColumn).GetValue<decimal>();
                    }
                    else
                    {
                        price = 1000000;
                        _dc.StateMessages.Add(($"Price not found in xml, set 1000000_{_dc.SuppName}_model: {row.Cell(modelColumnNumber)}_value: {row.Cell(priceColumn)}", ""));
                    }

                    quantity = row.Cell(quantityColumn).Value.ToString();

                    if (_dc.SupplierXmlSetting.SettingName == "Feron_excel")
                    {
                        unitsInBox = row.Cell(boxColumn).Value.ToString();

                        if (quantity.Contains('>') & quantity.Contains("ящик"))
                        {
                            quantity = unitsInBox;
                        }
                    }

                    int.TryParse(quantity, out var qty);

                    if (!_dc.XmlModelPriceList.TryAdd(model, price))
                        _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));

                    if (!_dc.XmlModelQuantityList.TryAdd(model, qty))
                        _dc.StateMessages.Add(($"error_Duplicate model in excel file {_dc.SuppName} {model}", "red"));
                }
            }
        }
    }

    private void GetGammaQtyXmlValues()
    {
        XmlDocument xmlDoc = new();

        int quantityNode;
        string model = "";
        //_dc.XmlModelQuantityList.Clear();

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

            quantityNode = quantities.Sum();

            _dc.XmlModelQuantityList.TryAdd(model, quantityNode);
        }
    }

    #endregion

    private void UpdatePrices()
    {
        _dc.SkusToUpdate = _dc.DbCodeModelPriceList.Select(s => s.Item1).ToList();

        foreach (var dbModel in _dc.DbCodeModelPriceList)
        {
            string sku = dbModel.Item1;
            var productToUpdate = _dc.Products.FirstOrDefault(p => p.Sku == sku);
            if (productToUpdate == null)
            {
                continue;
            }

            if (_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K")
            {
                _dc.ProductsManualSetPrices = _dbContextGamma.ProductsManualSetPrices.Where(n => _dc.SkusToUpdate.Contains(n.Sku)).ToList();

                if (_dc.ProductsManualSetPrices.Any(p => p.Sku == productToUpdate.Sku)) //ручне встановлення наявності.
                {
                    var manualValue = _dc.ProductsManualSetPrices.FirstOrDefault(p => p.Sku == sku)?.SetInStockPrice ?? 0;

                    if (dbModel.Item3 != manualValue)
                    {
                        _dbContextGamma.NgProducts.Where(x => x.Sku == sku).Update(x => new NgProduct { Price = manualValue });

                        _dc.StateMessages.Add(($"manualPrice_{sku}_{dbModel.Item2}_{_dc.SuppName}_{dbModel.Item5}_SetValue:_{manualValue} грн", "black"));
                        continue;
                    }
                }
            }

            if (_dc.XmlModelPriceList.TryGetValue(dbModel.Item2, out var xmlPrice))
            {
                if (_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K")
                {
                    xmlPrice = (xmlPrice + (xmlPrice * 0.4m)) * 50m;
                }

                if (dbModel.Item3 != xmlPrice)
                {
                    try
                    {
                        if (dbModel.Item3 < xmlPrice)
                        {

                            _dbContextGamma.NgProducts.Where(x => x.Sku == sku).Update(x => new NgProduct { Price = xmlPrice });
                            _dc.StateMessages.Add(($"+_{sku}_{dbModel.Item2}_{_dc.SuppName}_ price increased.{CutString(dbModel.Item5)}_Old - new:_{dbModel.Item3}_{xmlPrice}", "purple"));
                        }
                        else
                        {

                            if (xmlPrice != 0)
                            {
                                _dbContextGamma.NgProducts.Where(x => x.Sku == sku).Update(x => new NgProduct { Price = xmlPrice });
                                _dc.StateMessages.Add(($"-_{sku}_{dbModel.Item2}_{_dc.SuppName}_ price decreased.{CutString(dbModel.Item5)} Old - new:_{dbModel.Item3}_{xmlPrice}", "blue"));
                            }
                        }
                    }
                    catch (Exception)
                    {
                        _dc.StateMessages.Add((
                            $"error_Error occurred while price of {_dc.SuppName}  updated. DB data: {sku} {dbModel.Item2} _{CutString(dbModel.Item5)} {dbModel.Item3}. XML data {xmlPrice} ", "red"));
                    }
                }
            }
            else
            {
                _dc.StateMessages.Add(($"notUpd_{_dc.SuppName}_{sku}_{dbModel.Item2}_{dbModel.Item3}_{dbModel.Item5}_{_dc.CurrentTableDbColumnToUpdate} NotFound in xml", "red"));
            }

        }
        _dbContextGamma.SaveChanges();
    }


    private void UpdateQuantity()
    {
        if (_dc.WhatToUpdate != 3)
        {
            _dc.SkusToUpdate = _dc.DbCodeModelPriceList.Select(s => s.Item1).ToList();
            _dc.Products = _dbContextGamma.NgProducts.Where(p => _dc.SkusToUpdate.Contains(p.Sku))
                .Select(p => new ProductMinInfoModel
                {
                    Sku = p.Sku,
                    Model = p.Model,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    StockStatusId = p.StockStatusId
                })
                .ToList();
        }

        if (_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K")
        {
            if (_dc.ProductsManualSetQuanityList.Count > 0)
            {
                _dc.ProductsManualSetQuanityList = _dbContextGamma.ProductsManualSetQuanitys
                    .Where(m => _dc.SkusToUpdate.Contains(m.Sku)).ToList();
            }

            if (_dc.ProductsSetQuantityWhenMinList.Count > 0)
            {
                _dc.ProductsSetQuantityWhenMinList = _dbContextGamma.ProductsSetQuantityWhenMin
                    .Where(m => _dc.SkusToUpdate.Contains(m.Sku)).ToList();
            }
        }

        ProductMinInfoModel productToUpdate = new();

        foreach (var dbModel in _dc.DbCodeModelPriceList)
        {
            int? dbQtyValue = dbModel.Item4;
            string sku = dbModel.Item1;

            try
            {
                productToUpdate = _dc.Products.FirstOrDefault(p => p.Sku == sku);

                if (_dc.SuppName == "Gamma" || _dc.SuppName == "Gamma-K")
                {
                    if (_dc.ProductsManualSetQuanityList.Any(p => p.Sku == productToUpdate?.Sku)) //ручне встановлення наявності.
                    {
                        var manualValue = _dc.ProductsManualSetQuanityList.FirstOrDefault(p => p.Sku == sku)?.SetInStockQty ?? 0;

                        if (WriteQtyToDb(sku, manualValue))
                        {
                            _dc.StateMessages.Add(($"manualValue_{sku}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity set to default- {manualValue}. Old-_{dbQtyValue}", "black"));
                        }
                    }
                    else
                    {
                        if (RetrieveXmlValueFromList(dbModel.Item2, dbQtyValue, out int xmlQtyValue))
                        {
                            var minQtylValue = _dc.ProductsSetQuantityWhenMinList
                                .FirstOrDefault(p => p.Sku == sku)?.MinQuantity ?? 0;

                            if (_dc.ProductsSetQuantityWhenMinList.Any(p =>
                                    p.Sku == productToUpdate.Sku && xmlQtyValue < minQtylValue &&
                                    xmlQtyValue > 0)) // ручне встановлення мінімальних залишків
                            {
                                var setQtylValue = _dc.ProductsSetQuantityWhenMinList
                                    .FirstOrDefault(p => p.Sku == sku)?.SetQuantity ?? 0;

                                if (WriteQtyToDb(sku, xmlQtyValue))
                                {
                                    _dc.StateMessages.Add(($"setMin_{sku}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ quantity set to min: {setQtylValue}. Real xml was {xmlQtyValue}. DB was:_{dbQtyValue}", "yellow"));
                                }
                            }
                            else
                            {
                                if (dbQtyValue != xmlQtyValue)
                                {
                                    if (WriteQtyToDb(sku, xmlQtyValue))
                                    {
                                        if (dbQtyValue < xmlQtyValue)
                                        {
                                            _dc.StateMessages.Add(($"+ {_dc.CurrentTableDbColumnToUpdate}_{sku}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}. Old - new:_{dbQtyValue}_{xmlQtyValue}", "purple"));
                                        }
                                        else
                                        {
                                            _dc.StateMessages.Add(($"- {_dc.CurrentTableDbColumnToUpdate}_{sku}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}. Old - new:_{dbQtyValue}_{xmlQtyValue}", "blue"));
                                        }
                                    }
                                }
                                else  // uncomment else statement to see all positions, where Gamma quantity was equal to xml
                                {
                                    _dc.StateMessages.Add(($"Quantity not changed_{sku}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}. Real xml was {xmlQtyValue}. DB was:_{dbQtyValue}", "orange"));
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (RetrieveXmlValueFromList(dbModel.Item2, dbQtyValue, out int xmlQtyValue))
                    {
                        if (dbQtyValue != xmlQtyValue)
                        {
                            WriteQtyToDb(sku, xmlQtyValue);
                        }
                        //else  // uncomment else statement to see all positions, where NOT Gamma quantity was equal to xml
                        //{
                        //    _dc.StateMessages.Add(($"Quantity not changed_{sku}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}. Real xml was {xmlQtyValue}. DB was:_{dbQtyValue}", "orange"));
                        //}
                    }
                    else
                    {
                        if (WriteQtyToDb(sku, 0))
                        {
                            _dc.StateMessages.Add(($"set-0_{sku}_{dbModel.Item2}_{_dc.SuppName}_{CutString(dbModel.Item5)}_ NOT FOUND in XML. Set - 0. Old - new:_{dbQtyValue}_{xmlQtyValue}", "brown"));
                        }
                    }
                }
            }
            catch (Exception)
            {
                _dc.StateMessages.Add(($"error_Something happened while quantity of {_dc.SuppName}  updated. Data NOT ADD to DB: {sku} {dbModel.Item2} {CutString(dbModel.Item5)} {dbQtyValue}", "red"));
            }
        }
        _dbContextGamma.SaveChanges();
    }

    private bool WriteQtyToDb(string sku, int xmlValue) //, (string, string, decimal, int, string) dbModel)
    {
        int stockStatusIdToUpdate = xmlValue > 0 ? 7 : 5;

        try
        {
            _dbContextGamma.NgProducts.Where(x => x.Sku == sku).Update(x => new NgProduct { Quantity = xmlValue, StockStatusId = stockStatusIdToUpdate });
            return true;
        }
        catch (Exception e)
        {
            _dc.StateMessages.Add(($"error_Something happened while {_dc.CurrentTableDbColumnToUpdate} of {_dc.SuppName}  updated. Data NOT ADD to DB: {sku} {xmlValue}", "red"));
            return false;
        }
    }

    private bool RetrieveXmlValueFromList(string searchValueinXml, int? dbQtyValue, out int xmlQtyValue)
    {
        if (_dc.XmlModelQuantityList.TryGetValue(searchValueinXml, out xmlQtyValue))
        {
            if (dbQtyValue.HasValue && dbQtyValue.Value != xmlQtyValue)
            {
                xmlQtyValue = Math.Max(0, xmlQtyValue);
                return true;
            }
            return true;
        }
        xmlQtyValue = 0;
        return false;
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
