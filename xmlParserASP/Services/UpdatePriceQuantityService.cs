using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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

        public async Task<string> UpdatePriceAsync(List<int> settingsId, string tableColumnToUpdate)
        {
            if (settingsId == null)
            {
                return "Setting ID was not passed";
            }

            foreach (int id in settingsId)
            {
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

                        PropertyInfo propertyInfo = typeof(OcProduct).GetProperty(tableColumnToUpdate);

                        if (propertyInfo == null)
                        {
                            // Если такого свойства не существует, вернуть ошибку или обработать ситуацию
                            throw new ArgumentException("Invalid property name");
                        }

                        var codePriceList = await _dbContextGamma.OcProducts
                            .Where(p => currentSuppProductsList.Contains(p.ProductId))
                            .Select(p => new {p.Model, FieldValue = propertyInfo.GetValue(p).ToString() })
                            .ToListAsync();

                        // Get xml values

                        Dictionary<string, string> xmlModelPriceList = new();

                        XmlDocument xmlDoc = new();
                        xmlDoc.Load(suppSettings.Path);

                        XmlNodeList itemsList = xmlDoc.GetElementsByTagName(suppSettings.ProductNode);

                        #region Получение значений из XML и вставка в соответствующие колонки листа Products

                        string sku = "";
                        string price = "";

                        foreach (XmlNode item in itemsList)
                        {
                            string? model;

                            if (suppSettings.paramAttribute == null)
                            {
                                model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText;
                            }
                            else
                            {
                                if(item.Attributes["id"] != null)
                                {
                                    model = item.Attributes["id"]?.Value;
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            //string sku =  item.SelectSingleNode(suppSettings.ProductNode)?.InnerText ?? "";
                           

                            XmlNode parentItemNode = item.ParentNode;

                            if (parentItemNode != null)
                            {
                                price = parentItemNode.SelectSingleNode(tableColumnToUpdate)?.InnerText ?? "";

                            }

                            xmlModelPriceList.Add(model, price);

                            #endregion

                        }
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



        public string UpdatePrice(List<int> settingsId)
        {
            if (settingsId == null)
            {
                return new string ("setting ID was not passed");
            }            

            foreach (int id in settingsId)
            {
                var suppSettings = _dbContext.SupplierXmlSettings.Where(m => m.SupplierXmlSettingId == id).FirstOrDefault();

                var xmlPath = suppSettings.Path;                
                var suppXmlParsed = LoadAndParseXmlAsync(xmlPath);
                var xmlModel = suppSettings.ModelNode;
                var xmlPrice = suppSettings.PriceNode;

                var suppName = _dbContext.Suppliers.FirstOrDefault(m => m.SupplierId == suppSettings.SupplierId)?.SupplierName;

                var currentSuppProductsList = _dbContextGamma.OcProductToSuppliers.Where(m => m.SupplierId == suppName).Select(m => m.ProductId).ToList();

                var codePriceList = _dbContextGamma.OcProducts.Where(p => currentSuppProductsList.Contains(p.ProductId)).Select( t => new {t.Sku, t.Price}).ToList();


            }



            string updateResult = string.Empty;

            return updateResult;
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
