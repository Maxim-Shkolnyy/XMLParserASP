using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using xmlParserASP.Models;
using System.Drawing;
using System.Drawing.Imaging;

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
                var photoNodes = xmlDoc.SelectNodes($"//{PathModel.XMLPictureNode}");
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
                    // Create a dictionary to keep track of the count of each model
                    var modelCount = new Dictionary<string, int>();

                    // Iterate through each photo URL
                    foreach (XmlNode photoNode in photoNodes)
                    {
                        var photoUrl = photoNode.InnerText;
                        
                        var modelValue = photoNode.ParentNode.SelectSingleNode(PathModel.XMLModelNode).InnerText;
                        //var modelValue = photoNode.ParentNode.Attributes["id"]?.Value;                       

                        // Extract the original file name from the URL
                        var originalFileName = Path.GetFileName(photoUrl);

                        // Check if the model exists in the dictionary
                        if (!modelCount.ContainsKey(modelValue))
                        {
                            // Add the model to the dictionary with an initial count of 0
                            modelCount[modelValue] = 0;
                        }

                        // Increment the count for the model
                        modelCount[modelValue]++;

                        // Get the count value for the model
                        var count = modelCount[modelValue];

                        // Get the alphabetic character based on the count (A, B, C, ...)
                        var alphabeticCharacter = ((char)('A' + count - 1)).ToString();

                        // Combine modelValue, alphabeticCharacter, "Feron", and originalFileName to form the new file name
                        var imageName = $"{modelValue}-{alphabeticCharacter}-{PathModel.Supplier}_{originalFileName}";

                        // Check if the file already exists in the destination folder
                        var filePath = Path.Combine(PathModel.PhotoFolder, imageName);
                        if (System.IO.File.Exists(filePath))
                        {
                            continue; // Skip downloading if the file already exists
                        }

                        // Download the photo and save it to the selected folder
                        using (var response = await client.GetAsync(photoUrl))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var photoFilePath = Path.Combine(PathModel.PhotoFolder, imageName);

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
