using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
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
    private readonly TestGammaDBContext _dbContextTestGamma;
    private readonly GammaContext _dbContextGamma;
    private SupplierXmlSetting? suppSettings;
    private string? suppName;
    private List<(string, string)> stateMessages = new();
    private string currentTableDbColumnToUpdate = "";
    Dictionary<string, string> xmlModelPriceList = new();

    public UpdatePriceQuantityService(SupplierXmlSetting supplierXmlSetting, MyDBContext myDBContext, TestGammaDBContext dbContextTestGamma, GammaContext dbContextGamma)
    {
        _supplierXmlSetting = supplierXmlSetting;
        _dbContext = myDBContext;
        _dbContextTestGamma = dbContextTestGamma;
        _dbContextGamma=dbContextGamma;
    }

    public async Task<List<(string, string)>> UpdatePriceAsync(List<int> settingsId, string tableDbColumnToUpdate)
    {
        currentTableDbColumnToUpdate = tableDbColumnToUpdate;

        if (settingsId == null)
        {
            stateMessages.Add(("Setting ID was not passed", "red"));
            return stateMessages;
        }

        //PropertyInfo whatDbColumnWeNeedUpdate = typeof(OcProduct).GetProperty(tableDbColumnToUpdate);

        //if (whatDbColumnWeNeedUpdate == null)
        //{
        //    stateMessages.Add(("Null or absent model property was passed instead of table column name like 'Price' or 'Quantity'", "red"));
        //}

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
                    if (tableDbColumnToUpdate == "Price")
                    {
                        priceQuantityValue = product.Price.ToString(CultureInfo.CurrentCulture); 
                        productName = _dbContextGamma.OcProductDescriptions.Where(n => n.ProductId == product.ProductId).Select(m=>m.Name).FirstOrDefault();
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

            stateMessages.Add(($"{suppName} {tableDbColumnToUpdate} updated successful", "green"));

        }
        return stateMessages;
    }

    private void GetXmlValues()
    {
        XmlDocument xmlDoc = new();

        string fileExtension = Path.GetExtension(suppSettings.Path);
        string priceOrQuantityNode = "";
        string model = "";
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
                    if (suppSettings.paramAttribute == null)
                    {
                        model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText;
                    }
                    else
                    {
                        if (item.Attributes["id"] != null)
                        {
                            if (item.SelectSingleNode(suppSettings.ModelNode) == null)
                            {
                                continue;
                            }
                            model = item.Attributes["id"]?.Value;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (currentTableDbColumnToUpdate == "Price")
                    {
                        priceOrQuantityNode = item.SelectSingleNode(suppSettings.PriceNode)?.InnerText ?? "";
                    }
                    else
                    {
                        priceOrQuantityNode = item.SelectSingleNode(suppSettings.QuantityNode)?.InnerText ?? "";
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

    //public async Task<List<(string, string)>> UpdateQuantityAsync(List<int> settingsId, string tableDbColumnToUpdate)
    //{
    //    List<(string, string)> stateMessages = new();

    //    if (settingsId == null)
    //    {
    //        stateMessages.Add(("Setting ID was not passed", "red"));
    //        return stateMessages;
    //    }

    //    PropertyInfo whatDbColumnWeNeedUpdate = typeof(OcProduct).GetProperty(tableDbColumnToUpdate);

    //    if (whatDbColumnWeNeedUpdate == null)
    //    {
    //        stateMessages.Add(("Null or absent model property was passed instead of table column name like 'Price' or 'Quantity'", "red"));
    //    }

    //    foreach (int id in settingsId)
    //    {
    //        #region Получение текущих значений из БД

    //        var suppSettings = await _dbContext.SupplierXmlSettings
    //            .Where(m => m.SupplierXmlSettingId == id)
    //            .FirstOrDefaultAsync();
    //        if (suppSettings == null)
    //        {
    //            stateMessages.Add(("Supplier setting was not found in DB", "red"));
    //            continue;
    //        }

    //        var suppName = (await _dbContext.Suppliers.FirstOrDefaultAsync(m => m.SupplierId == suppSettings.SupplierId))?.SupplierName;

    //        if (suppName == null)
    //        {
    //            stateMessages.Add(("Supplier name was not found in DB", "red"));
    //            continue;
    //        }

    //        var currentSuppProductsList = await _dbContextGamma.OcProductToSuppliers
    //            .Where(m => m.SupplierId == suppName)
    //            .Select(m => m.ProductId)
    //            .ToListAsync();

    //        if (currentSuppProductsList == null)
    //        {
    //            stateMessages.Add(($"Supplier {suppName} has no one product in DB", "red"));
    //            continue;
    //        }

    //        var products = await _dbContextGamma.OcProducts
    //            .Where(p => currentSuppProductsList.Contains(p.ProductId))
    //            .ToListAsync();

    //        string fieldValue = "";

    //        var dbCodeModelPriceList = products.Select(p =>
    //        {
    //            try
    //            {
    //                fieldValue = whatDbColumnWeNeedUpdate.GetValue(p)?.ToString();
    //            }
    //            catch (Exception ex)
    //            {
    //                Debug.WriteLine($"Error processing field {whatDbColumnWeNeedUpdate.Name}, {whatDbColumnWeNeedUpdate.GetValue(p)}: {ex.Message}");
    //            }

    //            return (p.Sku, p.Model, fieldValue);
    //        }).ToList();

    //        //var dbCodePriceList = await _dbContextGamma.OcProducts
    //        //    .Where(p => currentSuppProductsList.Contains(p.ProductId))
    //        //    .Select(p => new { p.Sku, p.Model, FieldValue = whatDbColumnWeNeedUpdate.GetValue(p).ToString() })
    //        //    .ToListAsync();
    //        #endregion

    //        #region Получение значений из XML


    //        Dictionary<string, string> xmlModelPriceList = new();

    //        XmlDocument xmlDoc = new();

    //        string fileExtension = Path.GetExtension(suppSettings.Path);
    //        string price = "";
    //        string model = "";


    //        xmlDoc.Load(suppSettings.Path);
    //        //if (fileExtension == ".xml")
    //        //{
    //        //    xmlDoc.Load(suppSettings.Path);
    //        //}
    //        //else
    //        //{
    //        //    xmlDoc.LoadXml(suppSettings.Path);
    //        //}

    //        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(suppSettings.ProductNode);

    //        if (suppSettings.MainProductNode != null)
    //        {
    //            XmlNodeList parentItemsList = xmlDoc.GetElementsByTagName(suppSettings.MainProductNode);

    //            foreach (XmlNode items in parentItemsList)
    //            {
    //                foreach (XmlNode item in itemsList)
    //                {
    //                    if (suppSettings.paramAttribute == null)
    //                    {
    //                        model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText;
    //                    }
    //                    else
    //                    {
    //                        if (item.Attributes["id"] != null)
    //                        {
    //                            if (item.SelectSingleNode(suppSettings.ModelNode) == null)
    //                            {
    //                                continue;
    //                            }
    //                            model = item.Attributes["id"]?.Value;
    //                        }
    //                        else
    //                        {
    //                            continue;
    //                        }
    //                    }

    //                    price = item.SelectSingleNode(suppSettings.PriceNode)?.InnerText ?? "";

    //                    if (!xmlModelPriceList.ContainsKey(model))
    //                    {
    //                        xmlModelPriceList.Add(model, price);
    //                    }

    //                }
    //            }
    //        }
    //        else
    //        {
    //            foreach (XmlNode item in itemsList)
    //            {
    //                if (suppSettings.paramAttribute == null)
    //                {
    //                    if (item.SelectSingleNode(suppSettings.ModelNode) == null)
    //                    {
    //                        continue;
    //                    }
    //                    model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText;
    //                }
    //                else
    //                {
    //                    if (item.Attributes["id"] != null)
    //                    {
    //                        model = item.Attributes["id"]?.Value;
    //                    }
    //                    else
    //                    {
    //                        continue;
    //                    }
    //                }

    //                if (item.SelectSingleNode(suppSettings.PriceNode) == null)
    //                {

    //                    continue;
    //                }
    //                price = item.SelectSingleNode(suppSettings.PriceNode)?.InnerText ?? "";

    //                if (!xmlModelPriceList.ContainsKey(model))
    //                {
    //                    xmlModelPriceList.Add(model, price);
    //                }

    //                #endregion
    //            }
    //        }



    //        UpdatePrices(dbCodeModelPriceList, xmlModelPriceList);

    //        stateMessages.Add(($"{suppName} {tableDbColumnToUpdate} updated successful", "darkgreen"));
    //    }

    //    return stateMessages;
    //}



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
                                stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{dbModel.Item4}_ price increased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                            }

                        }
                        else
                        {
                            var productToUpdate = _dbContextGamma.OcProducts.FirstOrDefault(p => p.Sku == dbModel.Item1);
                            if (productToUpdate != null)
                            {
                                productToUpdate.Price = normalizedXmlValue;

                                stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{dbModel.Item4}_ price decreased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    stateMessages.Add(($"Error occurred while price of {suppName}  updated. DB data: {dbModel.Item1} {dbModel.Item2} _{dbModel.Item4} {dbModel.Item3}. XML data {xmlValue} ", "red"));
                }
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
                                productToUpdate.Quantity = currentXmlValue;
                                stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{dbModel.Item4}_ quantity increased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "purple"));
                            }
                        }
                        else
                        {
                            var productToUpdate = _dbContextGamma.OcProducts.FirstOrDefault(p => p.Sku == dbModel.Item1);
                            if (productToUpdate != null)
                            {
                                productToUpdate.Quantity = currentXmlValue;

                                stateMessages.Add(($"{dbModel.Item1}_{dbModel.Item2}_{suppName}_{dbModel.Item4}_ quantity decreased. Our - new:_{dbModel.Item3}_{currentXmlValue}", "blue"));
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    stateMessages.Add(($"Error occurred while quantity of {suppName}  updated. DB data: {dbModel.Item1} {dbModel.Item2} {dbModel.Item4} {dbModel.Item3}. XML data {xmlValue} ", "red"));
                }
            }
        }
        _dbContextGamma.SaveChanges();
    }


    public async Task<XDocument> LoadAndParseXmlAsync(string url)
    {
        using (var client = new HttpClient())
        {
            var xmlString = await client.GetStringAsync(url);
            return XDocument.Parse(xmlString);
        }
    }
}
