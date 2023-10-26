using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services
{
    public class UpdateMainXml
    {
        private GammaContext _dbContextGamma;

        public UpdateMainXml(GammaContext gammaContext)
        {
            _dbContextGamma = gammaContext;
        }

        public void UpdateGammaXml()
        {
            var gammaAllProducts = _dbContextGamma.OcProducts.Where(p =>!p.Sku.StartsWith("4")). ToList();

            var skuPriceQtyString = gammaAllProducts.Select(p => new
            {
                ProducrId = p.ProductId.ToString(),
                Sku = p.Sku.ToString(), 
                Price = p.Price.ToString(),
                Quantity = p.Quantity.ToString()
            });

            var skuPriceQty = gammaAllProducts.Select(p => new
            {
                p.ProductId,
                p.Sku,
                p.Price,
                p.Quantity
            });

            var nameCat =
                _dbContextGamma.OcProductToCategories.Where(p => p.ProductId).Contains(n => n..)       }

        public void UpdateSuppliersXml()
        {

        }
    }
}
