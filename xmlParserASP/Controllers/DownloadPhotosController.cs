using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using xmlParserASP.Models;

namespace xmlParserASP.Controllers
{
    public class DownloadPhotosController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // [HttpPost]
        public async Task<ActionResult> Index()
        {
            try
            {
                // Load the XML file
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(PathModel.Path);

                // Get the photo URLs from the XML
                var photoNodes = xmlDoc.SelectNodes("//picture");
                if (photoNodes == null)
                {
                    // Handle the case when no photo nodes are found in the XML
                    ViewBag.Message = "No photo URLs found in the XML.";
                    return View("Index");
                }

                // Create a HttpClient to download the photos
                using (var client = new HttpClient())
                {
                    // Iterate through each photo URL
                    foreach (XmlNode photoNode in photoNodes)
                    {
                        var photoUrl = photoNode.InnerText;

                        // Download the photo and save it to the specified folder
                        using (var response = await client.GetAsync(photoUrl))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var fileName = Path.GetFileName(photoUrl);
                                var photoFilePath = Path.Combine(PathModel.PhotoFolder, fileName);

                                using (var photoStream = await response.Content.ReadAsStreamAsync())
                                {
                                    using (var fileStream = new FileStream(photoFilePath, FileMode.Create))
                                    {
                                        await photoStream.CopyToAsync(fileStream);
                                    }
                                }
                            }
                        }
                    }
                }

                ViewBag.Message = "Photos downloaded successfully.";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View("Ok");
        }

    }
}
