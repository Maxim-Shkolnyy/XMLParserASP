using Microsoft.EntityFrameworkCore;
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
                    var xmlPath = suppSettings.Path;
                    if (xmlPath != null)
                    {
                        var suppXmlParsed = await LoadAndParseXmlAsync(xmlPath);

                    }
                    var xmlModel = suppSettings.ModelNode;
                    var xmlPrice = suppSettings.PriceNode;

                    var suppName = (await _dbContext.Suppliers
                        .FirstOrDefaultAsync(m => m.SupplierId == suppSettings.SupplierId))?.SupplierName;

                    if (suppName != null)
                    {
                        var currentSuppProductsList = await _dbContextGamma.OcProductToSuppliers
                            .Where(m => m.SupplierId == suppName)
                            .Select(m => m.ProductId)
                            .ToListAsync();

                        var codePriceList = await _dbContextGamma.OcProducts
                            .Where(p => currentSuppProductsList.Contains(p.ProductId))
                            .Select(t => new { t.Sku, t.Price })  // передати  у метод замість поля ціна ззовні
                            .ToListAsync();

                        
                    }
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
