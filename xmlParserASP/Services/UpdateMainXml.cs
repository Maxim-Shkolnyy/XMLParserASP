using Newtonsoft.Json;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Entities.TestGamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services;

public class UpdateMainXml
{
    private GammaContext _dbContextGamma;

    public UpdateMainXml(GammaContext gammaContext)
    {
        _dbContextGamma = gammaContext;
    }

    public string UpdateGammaXml()
    {
        var gammaAllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") & !p.Sku.StartsWith("5")).ToList();


        var AllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") && !p.Sku.StartsWith("5")).
        Join(_dbContextGamma.OcProductDescriptions.Where(p => p.LanguageId == 4), o => o.ProductId, i => i.ProductId, (o, i) => new
        {
            o.ProductId,
            o.Sku,
            i.Name,

        });

        string str = JsonConvert.SerializeObject(AllProducts);

        return str;

        var maxProd = _dbContextGamma.OcProducts.Where(n => n.Sku.StartsWith("4")).
            Join(_dbContextGamma.OcProductDescriptions, o => o.ProductId, i => i.ProductId, (o, i) => new
            {
                o.Sku,
                i.Name
            });

        // (o,i) => new { p.ProductId   }
        // int fun(OCProduct o, OCProduct i)
        // {
        //      return p.ProductId;
        // }

        // LINQ to Objects 
        // produts.Where(p => File.ReadAllLines().Contains(p.Name))

        


        var skuPriceQty = gammaAllProducts.Select(p => new
        {
            p.ProductId,
            p.Sku,
            p.Price,
            p.Quantity
        });

        var gammaNames = _dbContextGamma.OcProductDescriptions.Where(n => n.LanguageId == 4).Select(t => new
        {
            t.ProductId,
            t.Name

        });



    }

    public void UpdateSuppliersXml()
    {

    }

}
