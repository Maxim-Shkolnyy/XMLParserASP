using Microsoft.AspNetCore.Mvc;
using System.Xml;
using xmlParserASP.Models;
using System.Drawing;
using System.Drawing.Imaging;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc.Rendering;
using xmlParserASP.Entities;
using xmlParserASP.Presistant;
using xmlParserASP.Services;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace xmlParserASP.Controllers
{
    public class DownloadPhotosController : Controller
    {
        private readonly MyDBContext _dbContext;
        private string? suppName;
        private SupplierXmlSetting _suppSetting;

        public DownloadPhotosController(MyDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //var myContext = _dbContext.SupplierXmlSettings;

            var settingsWithSupplier = _dbContext.SupplierXmlSettings.Where(s => s.Supplier != null).Include(m => m.Supplier).ToList();

            //return View(settingsWithSupplier);

            var model = new DownloadPhotosViewModel
            {
                SupplierXmlSettings = _dbContext.SupplierXmlSettings.Include(m => m.Supplier).ToList()
            };

            var stringPath = new List<SelectListItem>
            {
                new SelectListItem { Text = "Select file folder", Value = "" },
                new SelectListItem { Text = "D:\\Downloads\\", Value = "D:\\Downloads\\" },
                new SelectListItem { Text = "C:\\Downloads\\", Value = "C:\\Downloads\\" },
                new SelectListItem { Text = "D:\\Downloads\\Telegram Desktop\\", Value = "D:\\Downloads\\Telegram Desktop\\" }
            };
            ViewBag.stringPath = stringPath;
            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> DownloadFromXml(int? selectedSupplierXmlSetting, bool renamePhotos, string prefix, string mainPart, string suffix)
        {
            _suppSetting = _dbContext.SupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId == selectedSupplierXmlSetting);
            if (_suppSetting == null)
            {
                ViewBag.MessageNoURL = "Supplier XML setting not found.";
                return View("Index");
            }

            suppName = _dbContext.Suppliers
                .Where(s => s.SupplierId == _suppSetting.SupplierId)
                .Select(s => s.SupplierName)
                .FirstOrDefault();

            try
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(_suppSetting.Path);

                var photoNodes = xmlDoc.SelectNodes($"//{_suppSetting.PictureNode}");
                if (photoNodes == null)
                {
                    ViewBag.MessageNoURL = "No photo URLs found in the XML.";
                    return View("Index");
                }

                //var tasks = new List<Task>();
                var totalPhotosDownloaded = 0;
                var totalPhotosResized = 0;
                var totalPhotoPassedExists = 0;
                var imgNameDownload = 0;
                var imgNameCannotDownload = 0;
                var newPhotosAdded = 0;
                var modelCount = new Dictionary<string, int>();
                var modelPhotoUrls = new Dictionary<string, HashSet<string>>();

                var wrongUrl = new List<KeyValuePair<string, string>>();

                foreach (XmlNode photoNode in photoNodes)
                {
                    //tasks.Add(Task.Run(async () =>
                    //{
                    var photoUrl = photoNode.InnerText;

                    string modelValue = null;

                    if (_suppSetting.paramAttribute == null)
                    {
                        modelValue = photoNode.SelectSingleNode(_suppSetting.ModelNode)?.InnerText ?? "";
                    }
                    else
                    {
                        modelValue = photoNode.ParentNode.Attributes[_suppSetting.paramAttribute]?.Value;
                    }

                    // Очистка и преобразование modelValue
                    if (!string.IsNullOrEmpty(modelValue))
                    {
                        modelValue = SanitizeModelValue(modelValue);

                        if (!modelCount.ContainsKey(modelValue))
                        {
                            modelCount[modelValue] = 0;
                            modelPhotoUrls[modelValue] = new HashSet<string>();
                            totalPhotoPassedExists++;
                        }
                        modelCount[modelValue]++;
                    }

                    var originalFileName = Path.GetFileName(photoUrl);

                    if (!string.IsNullOrEmpty(modelValue))
                    {
                        var count = modelCount[modelValue];
                        var alphabeticCharacter = ((char)('A' + count - 1)).ToString();
                        string imageName = null;
                        if (renamePhotos)
                        {
                            imageName = $"{modelValue}-{alphabeticCharacter}-{suppName}_{originalFileName}";
                        }
                        else
                        {
                            imageName = $"{originalFileName}";
                        }

                        var filePath = Path.Combine(_suppSetting.PhotoFolder, imageName);

                        if (System.IO.File.Exists(filePath))
                        {
                            totalPhotoPassedExists++;
                            //return;
                        }

                        if (modelPhotoUrls[modelValue].Contains(photoUrl))
                        {
                            totalPhotoPassedExists++;
                            //return;
                        }

                        using (var client = new HttpClient())
                        {
                            try
                            {
                                using (var response = await client.GetAsync(photoUrl))
                                {
                                    if (response.IsSuccessStatusCode)
                                    {
                                        var photoFilePath = Path.Combine(_suppSetting.PhotoFolder, imageName);

                                        using (var photoStream = await response.Content.ReadAsStreamAsync())
                                        {
                                            using (var image = Image.FromStream(photoStream))
                                            {
                                                photoStream.Seek(0, SeekOrigin.Begin);

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

                                                modelPhotoUrls[modelValue].Add(photoUrl);
                                                totalPhotosDownloaded++;
                                                newPhotosAdded++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        wrongUrl.Add(new KeyValuePair<string, string>(modelValue, photoUrl));
                                        imgNameCannotDownload++;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"Error downloading photo: {ex.Message}");
                            }
                        }
                    }
                    //}));
                }

                //await Task.WhenAll(tasks);

                ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}. Can't download. Wrong URL: {imgNameCannotDownload}";
                ViewBag.WrongUrl = wrongUrl;
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View("DownloadFromXml");
        }

        private string SanitizeModelValue(string modelValue)
        {
            string sanitizedValue = Regex.Replace(modelValue, @"[^a-zA-Z0-9-]", "-");

            sanitizedValue = sanitizedValue.ToLowerInvariant();

            return sanitizedValue;
        }



        [HttpPost]
        public async Task<ActionResult> DownloadFromXL(IFormFile? xmlFile,  int? ModelColumn, int? PictureColumn, int? SheetNumber) //string? filePath,
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
                    List<KeyValuePair<string, string>> wrongUrl = new();
                    int cannotDownload = 0;
                    int newPhotosAdded = 0;

                    //string excelFilePath = PathModel.Path;
                    string fileFileName = xmlFile.FileName;
                    string tempFolderPath = Path.GetTempPath();

                    string tempFilePath = Path.Combine(tempFolderPath, fileFileName);

                    using (var stream = new FileStream(tempFilePath, FileMode.Create))
                    {
                        await xmlFile.CopyToAsync(stream);
                    }

                    string modelColumnName = ModelColumn.ToString();

                    string photoUrlColumnName = PictureColumn.ToString();

                    int numberOfSheet = SheetNumber ?? 1;
                    

                    using (var workbook = new XLWorkbook(tempFilePath))
                    {
                        var worksheet = workbook.Worksheet(numberOfSheet); // Sheet Number
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
                            var cleanOriginalFileName = DelSpecialSymbols.ToLowerAndSpecialSymbolsToDashes(originalFileName);

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

                            var imageName = $"{modelValue}-{alphabeticCharacter}-{PathModel.Supplier}_{cleanOriginalFileName}";

                            //var fullFilePath = Path.Combine(PathModel.PhotoFolder, imageName);

                            if (modelPhotoUrls[modelValue].Contains(photoUrl))
                            {
                                totalPhotoPassedExists++;
                                currentRow = currentRow.RowBelow();
                                continue;
                            }

                            using (var response = await client.GetAsync(photoUrl))
                            {
                                if (response.IsSuccessStatusCode)
                                {
                                    string? photoFilePath = Path.Combine(PathModel.PhotoFolder, imageName) ?? @"D:\\Downloads\img\";

                                    using (var photoStream = await response.Content.ReadAsStreamAsync())
                                    {
                                        using (var image = Image.FromStream(photoStream))
                                        {
                                            photoStream.Seek(0, SeekOrigin.Begin);

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
                                    wrongUrl.Add(new KeyValuePair<string, string>(modelValue, photoUrl));
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
                    System.IO.File.Delete(tempFilePath);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View("DownloadFromXl");
        }



    }
}
