using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services;

public class UpdateMainXml
{
    private GammaContext _dbContextGamma;

    public UpdateMainXml(GammaContext gammaContext)
    {
        _dbContextGamma = gammaContext;
    }

    public void UpdateGammaXml()
    {
        var gammaAllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") & !p.Sku.StartsWith("5")).ToList();


        var AllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") & !p.Sku.StartsWith("5")).
            Join(_dbContextGamma.OcProductDescriptions.Where(m => m.LanguageId == 4)
                .Select(n => new
                {
                    n.ProductId,
                    n.Description
                });





        var skuPriceQty = gammaAllProducts.Select(p => new
        {
            p.ProductId,
            p.Sku,
            p.Price,
            p.Quantity
        });

        var gammaNames = _dbContextGamma.OcProductDescriptions.Where(n => n.LanguageId ==4).Select(t => new
        {
            t.ProductId,
            t.Name

        });



    }

    public void UpdateSuppliersXml()
    {

    }

}
