using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using xmlParserASP.Models;
//using System.Drawing;
//using System.Drawing.Imaging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace xmlParserASP.Controllers
{
    public class DownloadPhotosController : Controller
    {
        public async Task<ActionResult> Index()
        {
            try
            {               
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(PathModel.Path);

                var photoNodes = xmlDoc.SelectNodes($"//{PathModel.XMLPictureNode}");
                if (photoNodes == null)
                {
                    ViewBag.Message = "No photo URLs found in the XML.";
                    return View("Index");
                }

                using (var client = new HttpClient())
                {
                    // Create a dictionary to keep track of the count of each model
                    var modelCount = new Dictionary<string, int>();
                    int totalPhotosDownloaded = 0;
                    int totalPhotosResized = 0;
                    int totalPhotoPassedExists = 0;

                    foreach (XmlNode photoNode in photoNodes)
                    {
                        var photoUrl = photoNode.InnerText;
                        
                        var modelValue = photoNode.ParentNode.SelectSingleNode(PathModel.XMLModelNode).InnerText;
                        //var modelValue = photoNode.ParentNode.Attributes["id"]?.Value;                       

                        var originalFileName = Path.GetFileName(photoUrl);

                        if (!modelCount.ContainsKey(modelValue))
                        {
                            // Add the model to the dictionary with an initial count of 0
                            modelCount[modelValue] = 0;
                            totalPhotoPassedExists++;
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
                            totalPhotoPassedExists++;
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
                                    if (photoStream != null && photoStream.Length > 0)
                                    {
                                        // Reset the position of the stream to the beginning
                                        photoStream.Seek(0, SeekOrigin.Begin);

                                        // Load the image from the stream using ImageSharp
                                        using (var image = Image.Load(photoStream))
                                        {
                                            // Check if the image exceeds the maximum size
                                            if (image.Width > 1000 || image.Height > 1000)
                                            {
                                                // Calculate the new dimensions while maintaining the aspect ratio
                                                int newWidth, newHeight;
                                                if (image.Width > image.Height)
                                                {
                                                    newWidth = 1000;
                                                    newHeight = (int)((float)image.Height / image.Width * newWidth);
                                                }
                                                else
                                                {
                                                    newHeight = 1000;
                                                    newWidth = (int)((float)image.Width / image.Height * newHeight);
                                                }

                                                // Resize the image using ImageSharp
                                                image.Mutate(x => x.Resize(newWidth, newHeight));

                                                // Save the resized image to the file
                                                using (var fileStream = new FileStream(photoFilePath, FileMode.Create))
                                                {
                                                    image.Save(fileStream, new JpegEncoder { Quality = 49 });
                                                }
                                                totalPhotosResized++;
                                            }
                                            else
                                            {
                                                // Save the original image to the file
                                                using (var fileStream = new FileStream(photoFilePath, FileMode.Create))
                                                {
                                                    photoStream.Seek(0, SeekOrigin.Begin);
                                                    await photoStream.CopyToAsync(fileStream);
                                                }
                                            }
                                            totalPhotosDownloaded++;
                                        }

                                    }
                                }
                            }
                        }


                    }
                    ViewBag.Message = $"Photos downloaded successfully. Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}";

                }
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
