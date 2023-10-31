using Newtonsoft.Json;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Entities.TestGamma;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;

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
        //var gammaAllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") & !p.Sku.StartsWith("5")).ToList();


        var AllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") && !p.Sku.StartsWith("5")).
        Join(_dbContextGamma.OcProductDescriptions.Where(p => p.LanguageId == 4),
            o => o.ProductId, i => i.ProductId, (o, i) => new
            {
                o.ProductId,
                o.Sku,
                i.Name,

            });


        var newQuery = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") && !p.Sku.StartsWith("5")).
            Join(_dbContextGamma.OcProductDescriptions.Where(p => p.LanguageId == 4),
                product => product.ProductId, prodDesc => prodDesc.ProductId, (product, prodDesc) => new
                {
                    product.ProductId,
                    product.Sku,
                    product.Price,
                    product.Quantity,
                    prodDesc.Name,

                }).
            Join(_dbContextGamma.OcProductToCategories, joined => joined.ProductId, prCat => prCat.ProductId, (joined, prCat) => new
            {
                joined.ProductId,
                joined.Sku,
                joined.Price,
                joined.Quantity,
                joined.Name,
                prCat.CategoryId

            }).
            Select(result => result);


        string str = JsonConvert.SerializeObject(AllProducts);



        var maxProd = _dbContextGamma.OcProducts.Where(n => n.Sku.StartsWith("4")).
            Join(_dbContextGamma.OcProductDescriptions, o => o.ProductId, i => i.ProductId, (o, i) => new
            {
                o.Sku,
                i.Name
            });

        var query = from product in _dbContextGamma.OcProducts
                    join prodName in _dbContextGamma.OcProductDescriptions on product.ProductId equals prodName.ProductId
                    join prodCat in _dbContextGamma.OcProductToCategories on product.ProductId equals prodCat.ProductId

                    select new ProductToXml
                    {
                        Sku = product.Sku,
                        Quantity = product.Quantity,
                        Price = product.Price,
                        Name = prodName.Name,
                        Category = prodCat.CategoryId
                    };



        return str;

    }

    public void UpdateSuppliersXml()
    {

    }

}
