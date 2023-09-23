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

                var getSuppName = _dbContext.Set<Supplier>().FirstOrDefault(m => m.SupplierId == suppSettings.SupplierId);

                //var df = _dbContextGamma.Set<OcProductToSupplier>(suppSettings.SupplierId);

                //var currentSuppliersId = _dbContextGamma.Set<OcProduct>().Where(c => c.ProductId == (suppSettings.SupplierId ==   ).ToListAsync();
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
