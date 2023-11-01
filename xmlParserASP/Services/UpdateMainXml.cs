using Newtonsoft.Json;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Entities.TestGamma;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;
using System.Xml.Serialization;
using System.Net;

namespace xmlParserASP.Services;

public class UpdateMainXml
{
    private GammaContext _dbContextGamma;
    private readonly string _ftpHost = "zi391919.ftp.tools";
    private readonly string _ftpUser = "zi391919_victor";
    private readonly string _ftpPass = "6C8z94TFhn";

    public UpdateMainXml(GammaContext gammaContext)
    {
        _dbContextGamma = gammaContext;
    }

    public string UpdateGammaXml()
    {
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

        var xmlSerializer = new XmlSerializer(typeof(List<ProductToXml>));

        using (MemoryStream stream = new())
        {
            xmlSerializer.Serialize(stream, query.ToList());
            stream.Seek(0, SeekOrigin.Begin);


            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri("https://gamma.net.ua/image/catalog/xml/exchange/max.xml"));

            request.Credentials = new NetworkCredential(_ftpUser, _ftpPass, _ftpHost);
            request.Method = WebRequestMethods.Ftp.UploadData;

            //using (var xmlString = new StreamWriter())




        }

        string str = "";
        return str;



        //var gammaAllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") & !p.Sku.StartsWith("5")).ToList();


        //var AllProducts = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") && !p.Sku.StartsWith("5")).
        //Join(_dbContextGamma.OcProductDescriptions.Where(p => p.LanguageId == 4),
        //    o => o.ProductId, i => i.ProductId, (o, i) => new
        //    {
        //        o.ProductId,
        //        o.Sku,
        //        i.Name,

        //    });


        //var newQuery = _dbContextGamma.OcProducts.Where(p => !p.Sku.StartsWith("4") && !p.Sku.StartsWith("5")).
        //    Join(_dbContextGamma.OcProductDescriptions.Where(p => p.LanguageId == 4),
        //        product => product.ProductId, prodDesc => prodDesc.ProductId, (product, prodDesc) => new
        //        {
        //            product.ProductId,
        //            product.Sku,
        //            product.Price,
        //            product.Quantity,
        //            prodDesc.Name,

        //        }).
        //    Join(_dbContextGamma.OcProductToCategories, joined => joined.ProductId, prCat => prCat.ProductId, (joined, prCat) => new
        //    {
        //        joined.ProductId,
        //        joined.Sku,
        //        joined.Price,
        //        joined.Quantity,
        //        joined.Name,
        //        prCat.CategoryId

        //    }).
        //    Select(result => result);


        //string str = JsonConvert.SerializeObject(AllProducts);



        //var maxProd = _dbContextGamma.OcProducts.Where(n => n.Sku.StartsWith("4")).
        //    Join(_dbContextGamma.OcProductDescriptions, o => o.ProductId, i => i.ProductId, (o, i) => new
        //    {
        //        o.Sku,
        //        i.Name
        //    });
    }

    public void UpdateSuppliersXml()
    {

    }

}
