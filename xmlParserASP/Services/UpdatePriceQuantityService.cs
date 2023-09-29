using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using xmlParserASP.Controllers;
using xmlParserASP.Entities;
using xmlParserASP.Entities.TestGamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services
{
    public class UpdatePriceQuantityService
    {
        private readonly SupplierXmlSetting _supplierXmlSetting;
        private readonly MyDBContext _dbContext;
        private readonly Presistant.TestGammaDBContext _dbContextGamma;

        public UpdatePriceQuantityService(SupplierXmlSetting supplierXmlSetting, MyDBContext myDBContext, TestGammaDBContext dbContextGamma)
        {
            _supplierXmlSetting = supplierXmlSetting;
            _dbContext = myDBContext;
            _dbContextGamma = dbContextGamma;
        }

        public async Task<string> UpdatePriceAsync(List<int> settingsId, string tableDbColumnToUpdate)
        {
            if (settingsId == null)
            {
                return "Setting ID was not passed";
            }

            foreach (int id in settingsId)
            {
                #region Получение текущих значений из БД
                var suppSettings = await _dbContext.SupplierXmlSettings
                    .Where(m => m.SupplierXmlSettingId == id)
                    .FirstOrDefaultAsync();

                if (suppSettings != null)
                {
                    var suppName = (await _dbContext.Suppliers
                        .FirstOrDefaultAsync(m => m.SupplierId == suppSettings.SupplierId))?.SupplierName;

                    if (suppName != null)
                    {
                        var currentSuppProductsList = await _dbContextGamma.OcProductToSuppliers
                            .Where(m => m.SupplierId == suppName)
                            .Select(m => m.ProductId)
                            .ToListAsync();

                        PropertyInfo propertyInfo = typeof(OcProduct).GetProperty(tableDbColumnToUpdate);

                        if (propertyInfo == null)
                        {
                            // Если такого свойства не существует, вернуть ошибку или обработать ситуацию
                            throw new ArgumentException("Null was passed instead of table column name");
                        }

                        var products = await _dbContextGamma.OcProducts
                            .Where(p => currentSuppProductsList.Contains(p.ProductId))
                            .ToListAsync();

                        var dbCodeModelPriceList = products.Select(p => {
                            string fieldValue = "";

                            try
                            {
                                fieldValue = propertyInfo.GetValue(p)?.ToString();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"Error processing field {propertyInfo.Name}, {propertyInfo.GetValue(p)}: {ex.Message}");
                            }

                            return (p.Sku, p.Model, fieldValue);
                            //return new { p.Sku, p.Model, FieldValue = fieldValue };
                        }).ToList();

                        //var dbCodePriceList = await _dbContextGamma.OcProducts
                        //    .Where(p => currentSuppProductsList.Contains(p.ProductId))
                        //    .Select(p => new { p.Sku, p.Model, FieldValue = propertyInfo.GetValue(p).ToString() })
                        //    .ToListAsync();
                        #endregion

                        #region Получение значений из XML


                        Dictionary<string, string> xmlModelPriceList = new();

                        XmlDocument xmlDoc = new();

                        string fileExtension = Path.GetExtension(suppSettings.Path);
                        string price = "";
                        string model = "";


                        xmlDoc.Load(suppSettings.Path);
                        //if (fileExtension == ".xml")
                        //{
                        //    xmlDoc.Load(suppSettings.Path);
                        //}
                        //else
                        //{
                        //    xmlDoc.LoadXml(suppSettings.Path);
                        //}

                        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(suppSettings.ProductNode);

                        if (suppSettings.MainProductNode != null)
                        {
                            XmlNodeList parentItemsList = xmlDoc.GetElementsByTagName (suppSettings.MainProductNode);

                            foreach (XmlNode items in parentItemsList)
                            {
                                foreach(XmlNode item in itemsList)
                                {
                                    if (suppSettings.paramAttribute == null)
                                    {
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

                                    price = item.SelectSingleNode(suppSettings.PriceNode)?.InnerText ?? "";

                                    xmlModelPriceList.Add(model, price);
                                }
                            }
                        }
                        else
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
                                        model = item.Attributes["id"]?.Value;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }

                                price = item.SelectSingleNode(suppSettings.PriceNode)?.InnerText ?? "";

                                xmlModelPriceList.Add(model, price);

                                #endregion
                            }
                            
                        }

                        UpdatePrices(dbCodeModelPriceList, xmlModelPriceList);



                    }
                }
                else
                {
                    string updateResult2 = "Not updated!";
                    return updateResult2;
                }
            }

            string updateResult = string.Empty;

            return updateResult;
        }



        private void UpdatePrices(List<(string, string, string)> dbCodeModelPriceList, Dictionary<string, string>xmlModelPriceList )
        {
            foreach (var dbModel in dbCodeModelPriceList)
            {
                var hjlk = dbModel.Item1;
            }

            foreach (var xmlModel in xmlModelPriceList)
            {
                var khl = xmlModel.Key;
            }
        }


        public string UpdateQuantity(List<int> settingsId)
        {
            if (settingsId == null)
            {
                return new string("setting ID was not passed");
            }

            foreach (int id in settingsId)
            {

            }

            string updateResult = string.Empty;

            return updateResult;
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
}
