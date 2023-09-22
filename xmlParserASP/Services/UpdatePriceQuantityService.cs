using System.Xml.Linq;
using xmlParserASP.Controllers;
using xmlParserASP.Entities;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services
{
    public class UpdatePriceQuantityService
    {
        private readonly SupplierXmlSetting _supplierXmlSetting;
        private readonly MyDBContext _dbContext;

        public UpdatePriceQuantityService(SupplierXmlSetting supplierXmlSetting, MyDBContext myDBContext)
        {
            _supplierXmlSetting = supplierXmlSetting;
            _dbContext = myDBContext;
        }
        public string UpdatePrice(List<int> settingsId)
        {
            if (settingsId == null)
            {
                return new string ("setting ID was not passed");
            }

            foreach (int id in settingsId)
            {
                var xmlPath = _supplierXmlSetting.Path;                
                var suppXmlParsed = LoadAndParseXmlAsync(xmlPath);

                var xmlModel = _supplierXmlSetting.ModelNode;
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
