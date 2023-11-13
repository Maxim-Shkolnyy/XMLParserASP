using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;
using System.Xml.Serialization;
using System.Net;
using FluentFTP;

namespace xmlParserASP.Services;

public class UpdateMainXml
{
    private GammaContext _dbContextGamma;
    private readonly string _ftpHost = "zi391919.ftp.tools";
    private readonly string _ftpUser = "zi391919_victor";
    private readonly string _ftpPass = "6C8z94TFhn";
    private readonly string _localFilePath = @"D:\ftp\";  // "/db_backups"
    private readonly string _ftpDir = "/exchange/";
    private readonly string _fileName = "products46.xml";
    private readonly int deletionDays = 3;

    public UpdateMainXml(GammaContext gammaContext)
    {
        _dbContextGamma = gammaContext;
    }

    public void UpdateGammaXml()
    {
        var query = from product in _dbContextGamma.OcProducts
            join prodName in _dbContextGamma.OcProductDescriptions.Where(p => p.LanguageId == 4) on product.ProductId equals prodName.ProductId
            join prodCat in _dbContextGamma.OcProductToCategories.
                    GroupBy(pc => pc.ProductId).Select(g => new { ProductId = g.Key, GroupId = g.FirstOrDefault().CategoryId })

                on product.ProductId equals prodCat.ProductId

            select new Mm_ProductToXml
            {
                Sku = product.Sku,
                Quantity = product.Quantity,
                Price = product.Price,
                Name = prodName.Name,
                Category = prodCat.GroupId  // Змінено тут з CategoryId на GroupId
            };


        //List<ProductToXml> products = query.ToList();

        var xmlSerializer = new XmlSerializer(typeof(List<Mm_ProductToXml>));

        var localFile = Path.Combine(_localFilePath, _fileName);

        using (FileStream stream = new(localFile, FileMode.Create))
        {
            xmlSerializer.Serialize(stream, query.ToList());
            //stream.Seek(0, SeekOrigin.Begin);
        }

        FTPUpload();
    }

    private void FTPUpload()
    {
        int attempts = 0;
        try
        {
            FtpClient client = new FtpClient(_ftpHost);
            client.Credentials = new NetworkCredential(_ftpUser, _ftpPass);


            //Trace.TraceInformation("Attempting to open an FTP connection.");

            client.Connect();

            if (!string.IsNullOrEmpty(_ftpDir) && _ftpDir != "/")
            {
                if (!client.DirectoryExists(_ftpDir))
                {
                    client.CreateDirectory(_ftpDir);
                }
            }

            foreach (FtpListItem item in client.GetListing(_ftpDir))
            {
                if (item.Type == FtpObjectType.File)
                {
                    DateTime time = client.GetModifiedTime(item.FullName);

                    if (time < DateTime.Now.AddDays(-deletionDays))
                        client.DeleteFile(item.FullName);
                }
            }

            string[] localFiles = Directory.GetFiles(_localFilePath);

            var oo = client.UploadFiles(localFiles, _ftpDir, FtpRemoteExists.Overwrite, true, FtpVerify.Retry);

            client.Disconnect();
            attempts = 0;
        }
        catch (Exception ex)
        {
            attempts++;

            if (attempts < 3)
            {
                Thread.Sleep(3000);
                FTPUpload();
            }
            else
            {
                Console.WriteLine($"3 unsuccessful attempts to connect to ftp server: {ex.ToString()}");
            }

        }
    }

    public void UpdateSuppliersXml()
    {

    }

}
