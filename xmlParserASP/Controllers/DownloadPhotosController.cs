using Microsoft.AspNetCore.Mvc;
using System.Xml;
using xmlParserASP.Models;
using System.Drawing;
using System.Drawing.Imaging;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc.Rendering;
using xmlParserASP.Entities;
using xmlParserASP.Presistant;

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

            var model = new DownloadPhotosViewModel
            {
                SupplierXmlSettings = _dbContext.SupplierXmlSettings.ToList()
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
            if (_suppSetting != null)
            {
                suppName = _dbContext.Suppliers
                    .Where(s => s.SupplierId == _suppSetting.SupplierId)
                    .Select(s => s.SupplierName)
                    .FirstOrDefault();
            }

            try
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(_suppSetting.Path);


                var photoNodes = xmlDoc.SelectNodes($"//{_suppSetting.PictureNode}");
                if (photoNodes == null)
                {
                    ViewBag.Message = "No photo URLs found in the XML.";
                    return View("Index");
                }

                using (var client = new HttpClient())
                {
                    var modelCount = new Dictionary<string, int>();
                    var modelPhotoUrls = new Dictionary<string, HashSet<string>>();
                    int totalPhotosDownloaded = 0;
                    int totalPhotosResized = 0;
                    int totalPhotoPassedExists = 0;
                    int imgNameDownload = 0;
                    int imgNameCannotDownload = 0;
                    int newPhotosAdded = 0;

                    var wrongUrl = new List<KeyValuePair<string, string>>();

                    foreach (XmlNode photoNode in photoNodes)
                    {
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


                        var originalFileName = Path.GetFileName(photoUrl);

                        if (!modelCount.ContainsKey(modelValue))
                        {
                            modelCount[modelValue] = 0;
                            modelPhotoUrls[modelValue] = new HashSet<string>();
                            totalPhotoPassedExists++;
                        }

                        modelCount[modelValue]++;
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
                            continue;
                        }

                        if (modelPhotoUrls[modelValue].Contains(photoUrl))
                        {
                            totalPhotoPassedExists++;
                            continue;
                        }

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

                    //if (newPhotosAdded == 0)
                    //{
                    //    ViewBag.Message = "No new photos added. All photos already exist in the destination folder.";
                    //}
                    //else
                    //{
                    ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}. Can't download. Wrong URL: {imgNameCannotDownload}";
                    ViewBag.WrongUrl = wrongUrl;
                    //}
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View("DownloadFromXml");
        }




        [HttpPost]
        public async Task<ActionResult> DownloadFromXL(IFormFile? xmlFile, string? filePath)
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
                    string excelFilePath = Path.Combine(filePath, xmlFile.FileName);

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
                                    var photoFilePath = Path.Combine(PathModel.PhotoFolder, imageName);

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
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred: " + ex.Message;
            }

            return View("DownloadFromXml");
        }



    }
}
