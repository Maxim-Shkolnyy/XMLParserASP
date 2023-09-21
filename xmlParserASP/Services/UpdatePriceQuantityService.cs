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
                var currentPrice = _supplierXmlSetting.ModelNode.
            }

            

            string uodateResult = string.Empty;

            return uodateResult;
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

            string uodateResult = string.Empty;

            return uodateResult;
        }
    }
}
