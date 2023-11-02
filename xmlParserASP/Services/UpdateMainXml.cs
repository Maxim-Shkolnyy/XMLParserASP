using Newtonsoft.Json;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Entities.TestGamma;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;
using System.Xml.Serialization;
using System.Net;
using FluentFTP;
using System.Diagnostics;

namespace xmlParserASP.Services;

public class UpdateMainXml
{
    private GammaContext _dbContextGamma;
    private readonly string _ftpHost = "zi391919.ftp.tools";
    private readonly string _ftpUser = "zi391919_victor";
    private readonly string _ftpPass = "6C8z94TFhn";
    private readonly string _remoteFilePath = @"/image/catalog/xml/gamma/old1s.xml"; //\image\catalog\xml\exchange\max.xml
    private readonly string _localFilePath = @"D:\Downloads\andr.txt";  // "/db_backups"

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

        List<ProductToXml> products = query.ToList();

        var xmlSerializer = new XmlSerializer(typeof(List<ProductToXml>));

        using (MemoryStream stream = new())
        {
            xmlSerializer.Serialize(stream, query.ToList());
            stream.Seek(0, SeekOrigin.Begin);

            using (FtpClient client = new FtpClient(_ftpHost, _ftpUser, _ftpPass))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    // Upload the file
                    client.UploadFile(_localFilePath, _remoteFilePath);

                    Console.WriteLine("File uploaded successfully.");

                    client.Disconnect();
                }
                else
                {
                    Console.WriteLine("Failed to connect to the FTP server.");
                }
            }


            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri($"ftp://{_ftpHost}/image/catalog/xml/exchange/max.xml"));

            //request.Credentials = new NetworkCredential(_ftpUser, _ftpPass);
            //request.Method = WebRequestMethods.Ftp.UploadFile;

            //using (Stream fileStream = File.OpenRead(@"D:\Downloads\andr.txt"))

            //using (Stream ftpStream = request.GetResponse().GetResponseStream())
            //{
            //    fileStream.CopyTo(ftpStream);
            //}
            //FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            //Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            //response.Close();





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

    static void FTPUpload()
    {
        try
        {
            FtpTrace.AddListener(new ConsoleTraceListener());

            FtpClient client = new FtpClient(ftpServer);
            client.Credentials = new NetworkCredential(ftpLogin, ftpPassword);
            client.RetryAttempts = 3;
            client.Connect();

            if (!string.IsNullOrEmpty(ftpDir) && ftpDir != "/")
            {
                if (!client.DirectoryExists(ftpDir))
                {
                    client.CreateDirectory(ftpDir);
                }
            }

            foreach (FtpListItem item in client.GetListing(ftpDir))
            {
                if (item.Type == FtpFileSystemObjectType.File)
                {
                    DateTime time = client.GetModifiedTime(item.FullName);

                    if (time < DateTime.Now.AddDays(-DeletionDays))
                        client.DeleteFile(item.FullName);
                }
            }

            string[] localFiles = Directory.GetFiles(backupDir);

            client.UploadFiles(localFiles, ftpDir, FtpExists.Skip, true, FtpVerify.Retry);

            client.Disconnect();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public void UpdateSuppliersXml()
    {

    }

}
