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
        public async Task<ActionResult> DownloadFromXml()
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
                    int totalPhotosDownloaded = 0;
                    int totalPhotosResized = 0;
                    int totalPhotoPassedExists = 0;

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

                        // DownloadFromXml the photo and save it to the selected folder
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
                                        totalPhotosDownloaded++;
                                    }
                                }
                            }
                        }


                    }
                    ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}";

                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
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
                    // Create a dictionary to keep track of the count of each model
                    var modelCount = new Dictionary<string, int>();
                    int totalPhotosDownloaded = 0;
                    int totalPhotosResized = 0;
                    int totalPhotoPassedExists = 0;

                    string excelFilePath = PathModel.Path;
                    string modelColumnName = PathModel.ModelXlColumn; // Replace with the name of the column containing model names
                    string photoUrlColumnName = PathModel.PictureXlColumn; // Replace with the name of the column containing photo URLs

                    using (var workbook = new XLWorkbook(excelFilePath))
                    {
                        var worksheet = workbook.Worksheet(PathModel.XlSheetNumber); // Sheet Number
                        var firstRowUsed = worksheet.FirstRowUsed();
                        var modelColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == modelColumnName)?.WorksheetColumn();
                        var photoUrlColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == photoUrlColumnName)?.WorksheetColumn();

                        if (modelColumn == null || photoUrlColumn == null)
                        {
                            ViewBag.Message = "Model and/or Photo URL column not found in the Excel file.";
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
                            //if (System.IO.File.Exists(filePath))
                            //{
                            //    totalPhotoPassedExists++;
                            //    continue; // Skip downloading if the file already exists
                            //}

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
                                            totalPhotosDownloaded++;
                                        }
                                    }
                                }
                            }

                            // Move to the next row
                            currentRow = currentRow.RowBelow();
                        }
                    }

                    ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}";
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
