using Microsoft.AspNetCore.Mvc;
using System.Xml;
using xmlParserASP.Models;
using System.Drawing;
using System.Drawing.Imaging;
using ClosedXML.Excel;

namespace xmlParserASP.Controllers
{
    public class DownloadPhotosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> DownloadFromXml(string? idAttribute)
        {
            try
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(PathModel.Path);

                var photoNodes = xmlDoc.SelectNodes($"//{PathModel.PictureNode}");
                if (photoNodes == null)
                {
                    ViewBag.Message = "No photo URLs found in the XML.";
                    return View("Index");
                }

                using (var client = new HttpClient())
                {
                    // Create a dictionary to keep track of the count of each model
                    var modelCount = new Dictionary<string, int>();
                    // Create a dictionary to keep track of downloaded photo URLs for each model
                    var modelPhotoUrls = new Dictionary<string, HashSet<string>>();
                    int totalPhotosDownloaded = 0;
                    int totalPhotosResized = 0;
                    int totalPhotoPassedExists = 0;
                    int imgNameDownload = 0;
                    int imgNameCannotDownload = 0;
                    int newPhotosAdded = 0;

                    foreach (XmlNode photoNode in photoNodes)
                    {
                        var photoUrl = photoNode.InnerText;

                        var modelValue = photoNode.ParentNode.SelectSingleNode(PathModel.ModelNode).InnerText;
                        //var modelValue = photoNode.ParentNode.Attributes["id"]?.Value;

                        var originalFileName = Path.GetFileName(photoUrl);

                        if (!modelCount.ContainsKey(modelValue))
                        {
                            // Add the model to the dictionary with an initial count of 0
                            modelCount[modelValue] = 0;
                            modelPhotoUrls[modelValue] = new HashSet<string>(); // Initialize the HashSet for photo URLs
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

                        // Check if the photo URL has been downloaded for this model before
                        if (modelPhotoUrls[modelValue].Contains(photoUrl))
                        {
                            totalPhotoPassedExists++;
                            continue; // Skip downloading if the photo URL has been downloaded before
                        }

                        // Download the photo and save it to the selected folder
                        using (var response = await client.GetAsync(photoUrl))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var photoFilePath = Path.Combine(PathModel.PhotoFolder, imageName);

                                using (var photoStream = await response.Content.ReadAsStreamAsync())
                                {
                                    // Load the image from the stream
                                    using (var image = Image.FromStream(photoStream))
                                    {
                                        photoStream.Seek(0, SeekOrigin.Begin);
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

                                            // Create a new bitmap with the resized dimensions
                                            using (var resizedImage = new Bitmap(image, newWidth, newHeight))
                                            {
                                                // Save the resized image to the file
                                                resizedImage.Save(photoFilePath, ImageFormat.Jpeg);
                                                totalPhotosResized++;
                                            }
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

                                        // Add the photo URL to the HashSet for this model
                                        modelPhotoUrls[modelValue].Add(photoUrl);
                                        totalPhotosDownloaded++;
                                        newPhotosAdded++; // Increment the new photos count
                                    }
                                }
                            }
                            else
                            {
                                ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}. Can`t download. Wrong URL: {imgNameCannotDownload}";
                            }
                        }
                    }

                    if (newPhotosAdded == 0)
                    {
                        ViewBag.Message = "No new photos added. All photos already exist in the destination folder.";
                    }
                    else
                    {
                        ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}. Can`t download. Wrong URL: {imgNameCannotDownload}";
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View("DownloadFromXml");
        }

        public async Task<ActionResult> DownloadFromXL()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var modelCount = new Dictionary<string, int>();
                    var modelPhotoUrls = new Dictionary<string, HashSet<string>>();
                    int totalPhotosDownloaded = 0;
                    int totalPhotosResized = 0;
                    int totalPhotoPassedExists = 0;
                    List<string> wrongUrl = new();
                    int cannotDownload = 0;
                    int newPhotosAdded = 0; 

                    string excelFilePath = PathModel.Path;
                    string modelColumnName = PathModel.ModelXlColumn; 
                    string photoUrlColumnName = PathModel.PictureXlColumn;

                    using (var workbook = new XLWorkbook(excelFilePath))
                    {
                        var worksheet = workbook.Worksheet(PathModel.XlSheetNumber); // Sheet Number
                        var firstRowUsed = worksheet.FirstRowUsed();
                        var modelColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == modelColumnName)?.WorksheetColumn();
                        var photoUrlColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == photoUrlColumnName)?.WorksheetColumn();

                        if (modelColumn == null || photoUrlColumn == null || worksheet == null)
                        {
                            ViewBag.Message = "Model, sheet and/or Photo URL column not found in the Excel file.";
                            return View("Index");
                        }

                        var currentRow = firstRowUsed.RowUsed().RowBelow(); // Skip the header row

                        while (!currentRow.Cell(modelColumn.ColumnNumber()).IsEmpty())
                        {
                            var modelValue = currentRow.Cell(modelColumn.ColumnNumber()).Value.ToString();
                            var photoUrl = currentRow.Cell(photoUrlColumn.ColumnNumber()).Value.ToString();

                            var originalFileName = Path.GetFileName(photoUrl);

                            if (!modelCount.ContainsKey(modelValue))
                            {
                                modelCount[modelValue] = 0;
                                modelPhotoUrls[modelValue] = new HashSet<string>(); // Initialize the HashSet for photo URLs
                                totalPhotoPassedExists++;
                            }

                            modelCount[modelValue]++;

                            // Get the count value for the model
                            var count = modelCount[modelValue];

                            var alphabeticCharacter = ((char)('A' + count - 1)).ToString();

                            var imageName = $"{modelValue}-{alphabeticCharacter}-{PathModel.Supplier}_{originalFileName}";

                            var filePath = Path.Combine(PathModel.PhotoFolder, imageName);

                            if (modelPhotoUrls[modelValue].Contains(photoUrl))
                            {
                                totalPhotoPassedExists++;
                                currentRow = currentRow.RowBelow();
                                continue; // Skip downloading if the photo URL has been downloaded before
                            }

                            // Download the photo and save it to the selected folder
                            using (var response = await client.GetAsync(photoUrl))
                            {
                                if (response.IsSuccessStatusCode)
                                {
                                    var photoFilePath = Path.Combine(PathModel.PhotoFolder, imageName);

                                    using (var photoStream = await response.Content.ReadAsStreamAsync())
                                    {
                                        using (var image = Image.FromStream(photoStream))
                                        {
                                            photoStream.Seek(0, SeekOrigin.Begin);
                                            // Check if the image exceeds the maximum size
                                            if (image.Width > 1000 || image.Height > 1000)
                                            {
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

                                                using (var resizedImage = new Bitmap(image, newWidth, newHeight))
                                                {
                                                    resizedImage.Save(photoFilePath, ImageFormat.Jpeg);
                                                    totalPhotosResized++;
                                                }
                                            }
                                            else
                                            {
                                                using (var fileStream = new FileStream(photoFilePath, FileMode.Create))
                                                {
                                                    photoStream.Seek(0, SeekOrigin.Begin);
                                                    await photoStream.CopyToAsync(fileStream);
                                                }
                                            }

                                            // Add the photo URL to the HashSet for this model
                                            modelPhotoUrls[modelValue].Add(photoUrl);
                                            totalPhotosDownloaded++;
                                            newPhotosAdded++; 
                                        }
                                    }
                                }
                                else
                                {
                                    wrongUrl.Add(photoUrl);
                                    cannotDownload++;
                                }
                            }

                            // Move to the next row
                            currentRow = currentRow.RowBelow();
                        }
                    }

                    if (newPhotosAdded == 0)
                    {
                        ViewBag.Message = "No new photos added. All photos already exist in the destination folder.";
                    }
                    else
                    {
                        ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}. Wrong URL, image was not downloaded: {cannotDownload}";
                        ViewBag.WrongUrl = wrongUrl;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View("DownloadFromXml");
        }


       
    }
}
