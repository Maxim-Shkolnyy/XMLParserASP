using Microsoft.AspNetCore.Mvc;
using System.Xml;
using xmlParserASP.Models;
using System.Drawing;
using System.Drawing.Imaging;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Text.RegularExpressions;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;
using xmlParserASP.Services;
using xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD.StringCleanerServices;
using MySqlX.XDevAPI.Common;
//using Windows.Storage.Pickers;

namespace xmlParserASP.Controllers;

public class DownloadPhotosController : Controller
{
    private readonly GammaContext _gammaContext;
    private string? suppName;
    private MmSupplierXmlSetting _suppSetting;
    private DownloadPhotosViewModel _model;
    private DownloadPhotosService _downloadPhotosService;
    private DownloadPhotosResultModel _resultModel;

    public DownloadPhotosController(GammaContext gammaContext, DownloadPhotosService downloadPhotosService, DownloadPhotosResultModel resultModel)
    {
        _gammaContext=gammaContext;
        _downloadPhotosService=downloadPhotosService;
        _resultModel=resultModel;

        _model = new DownloadPhotosViewModel
        {
            SupplierXmlSettings = _gammaContext.MmSupplierXmlSettings.ToList(),
            NgCategoryDescriptions = _gammaContext.NgCategoryDescriptions.Where(m => m.LanguageId == 3).ToList(),
            NgCategorys = _gammaContext.NgCategories.ToList(),
            NgProducts = _gammaContext.NgProducts.ToList(),
            NgProductImages = _gammaContext.NgProductImages.ToList(),
            NgProductToCategories = _gammaContext.NgProductToCategories.ToList(),
        };
    }
    public IActionResult Index()
    {
        return View(_model);
    }


    [HttpPost]
    public async Task<ActionResult> DownloadFromDB(int? selectedSupplierXmlSetting, int? SelectedCategoryId, bool Rename, string? desktopSubFolder, string? LinkPrefix)
    {
        List<int> childrenCategories = new();

        if (SelectedCategoryId != null)
        {
            childrenCategories = _model.NgCategorys.Where(m => m.ParentId == SelectedCategoryId).Select(n => n.CategoryId).ToList();
            childrenCategories.Insert(0, (int)SelectedCategoryId);
        }
        else
        {
            childrenCategories = _model.NgCategorys.Select(m => m.CategoryId).ToList();
        }

        List<int> productsIdsOfCurrentCategory = new();

        if (selectedSupplierXmlSetting == null)
        {
            productsIdsOfCurrentCategory = _model.NgProductToCategories.Where(m => childrenCategories.Contains(m.CategoryId)).Select(c => c.ProductId).ToList();
        }
        else
        {
            //Todo: get products only for current supplier. Implement select supplier in view

            _suppSetting = _gammaContext.MmSupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId == selectedSupplierXmlSetting);
            suppName = _gammaContext.MmSuppliers.Where(m => m.SupplierId == _suppSetting.SupplierId).Select(n => n.SupplierName).FirstOrDefault();

            productsIdsOfCurrentCategory = _model.NgProductToCategories.Where(m => childrenCategories.Contains(m.CategoryId)).Select(c => c.ProductId).ToList();
        }


        List<string>? productImages = _model.NgProducts.Where(m => productsIdsOfCurrentCategory.Contains(m.ProductId)).Select(c => c.Image).ToList();
        var additionalImages = _model.NgProductImages.Where(n => productsIdsOfCurrentCategory.Contains(n.ProductId)).Select(b => b.Image).ToList();

        productImages.AddRange(additionalImages);

        if (LinkPrefix != null)
        {
            productImages = productImages.Select(s => LinkPrefix  + s).ToList();
        }

        if (SelectedCategoryId == null)
        {
            productImages = productImages.Distinct().ToList();
        }

        _resultModel = await _downloadPhotosService.DownloadPhotos(productImages, desktopSubFolder, true);  // TODO: choose if resize (last parameter) from UI

        return View("DownloadPhotosResult", _resultModel);
    }



    [HttpPost]
    public async Task<ActionResult> DownloadFromXL(IFormFile? excelFile, int? selectedSupplierXmlSetting, string? ModelColumn, string? PictureColumn, int? SheetNumber, bool Rename, string? desktopSubFolder, string? LinkPrefix)
    {
        if (excelFile == null || PictureColumn == null || SheetNumber == null)
        {
            return BadRequest("One or more required parameters are missing.");
        }

        if (selectedSupplierXmlSetting != null)
        {
            _suppSetting = _gammaContext.MmSupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId == selectedSupplierXmlSetting);
            suppName = _gammaContext.MmSuppliers.Where(m => m.SupplierId == _suppSetting.SupplierId).Select(n => n.SupplierName).FirstOrDefault();
        }

        var imageUrlList = new List<(string, string)>();
        var noModelImageUrlList = new List<string>();

        using (var stream = excelFile.OpenReadStream())
        {
            using (var workbook = new XLWorkbook(stream))
            {
                var worksheet = workbook.Worksheet((int)SheetNumber);
                var firstRowUsed = worksheet.FirstRowUsed();
                var modelColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == ModelColumn)?.WorksheetColumn()?.ColumnNumber() ?? -1;
                var photoUrlColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == PictureColumn)?.WorksheetColumn().ColumnNumber() ?? 1;
                var rowsUsed = worksheet.RowsUsed();
                string modelValue = "";
                string photoUrl = "";
                

                if (modelColumn == -1)
                {
                    foreach (var row in rowsUsed)
                    {
                        photoUrl = row.Cell(photoUrlColumn).Value.ToString() ?? "";
                        if (!String.IsNullOrEmpty(photoUrl))
                        {
                            noModelImageUrlList.Add(photoUrl);
                        }
                    }
                }
                else //TODO: if Model was set and need rename image
                {
                    foreach (var row in rowsUsed)
                    {
                        modelValue = row.Cell(modelColumn).Value.ToString() ?? "";
                        photoUrl = row.Cell(photoUrlColumn).Value.ToString() ?? "";
                        if (!String.IsNullOrEmpty(photoUrl))
                        {
                            imageUrlList.Add((modelValue, photoUrl));
                        }
                    }
                }
            }
        }

        if (LinkPrefix != null)
        {
            noModelImageUrlList = noModelImageUrlList.Select(s => LinkPrefix  + s).ToList();
        }

        _resultModel = await _downloadPhotosService.DownloadPhotos(noModelImageUrlList, desktopSubFolder, true);  // TODO: choose if resize (last parameter) from UI

        return View("DownloadPhotosResult", _resultModel);

        //try
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var modelCount = new Dictionary<string, int>();
        //        var modelPhotoUrls = new Dictionary<string, HashSet<string>>();
        //        int totalPhotosDownloaded = 0;
        //        int totalPhotosResized = 0;
        //        int totalPhotoPassedExists = 0;
        //        List<KeyValuePair<string, string>> wrongUrl = new();
        //        int cannotDownload = 0;
        //        int newPhotosAdded = 0;

        //        string fileFileName = excelFile.FileName;
        //        string tempFolderPath = Path.GetTempPath();

        //        string tempFilePath = Path.Combine(tempFolderPath, fileFileName);

        //        using (var stream = new FileStream(tempFilePath, FileMode.Create))
        //        {
        //            await excelFile.CopyToAsync(stream);
        //        }

        //        int numberOfSheet = SheetNumber ?? 1;

        //        using (var workbook = new XLWorkbook(tempFilePath))
        //        {
        //            var worksheet = workbook.Worksheet(numberOfSheet);
        //            var firstRowUsed = worksheet.FirstRowUsed();
        //            var modelColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == ModelColumn)?.WorksheetColumn();
        //            var photoUrlColumn = firstRowUsed.CellsUsed().FirstOrDefault(c => c.Value.ToString() == PictureColumn)?.WorksheetColumn();

        //            if (photoUrlColumn == null || worksheet == null)
        //            {
        //                ViewBag.Message = "Model, sheet and/or Photo URL column not found in the Excel file.";
        //                return View("Index");
        //            }

        //            var currentRow = firstRowUsed.RowUsed().RowBelow(); // Skip the header row

        //            while (!currentRow.Cell(modelColumn.ColumnNumber()).IsEmpty())
        //            {
        //                var modelValue = currentRow.Cell(modelColumn.ColumnNumber()).Value.ToString();
        //                var photoUrl = currentRow.Cell(photoUrlColumn.ColumnNumber()).Value.ToString();
        //                if (LinkPrefix != null)
        //                {
        //                    photoUrl = LinkPrefix + photoUrl;
        //                }

        //                var originalFileName = Path.GetFileNameWithoutExtension(photoUrl);
        //                var extension = Path.GetExtension(photoUrl);
        //                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        //                var cleanOriginalFileName = DelSpecialSymbols.SpecialSymbolsToDashes(originalFileName);

        //                if (!modelCount.ContainsKey(modelValue))
        //                {
        //                    modelCount[modelValue] = 0;
        //                    modelPhotoUrls[modelValue] = new HashSet<string>(); // Initialize the HashSet for photo URLs                            
        //                }
        //                else
        //                {
        //                    totalPhotoPassedExists++;
        //                }

        //                modelCount[modelValue]++;

        //                // Get the count value for the model
        //                var count = modelCount[modelValue];

        //                var alphabeticCharacter = ((char)('A' + count - 1)).ToString();

        //                var imageName = $"{modelValue}-{alphabeticCharacter}-{suppName}_{cleanOriginalFileName}{extension}";



        //                var fullFilePath = Path.Combine(desktopPath, desktopSubFolder, imageName);

        //                if (modelPhotoUrls[modelValue].Contains(photoUrl))
        //                {
        //                    totalPhotoPassedExists++;
        //                    currentRow = currentRow.RowBelow();
        //                    continue;
        //                }

        //                using (var response = await client.GetAsync(photoUrl))
        //                {
        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        //string? photoFilePath = Path.Combine(_suppSetting.PhotoFolder, imageName) ?? @"D:\\Downloads\img\";

        //                        using (var photoStream = await response.Content.ReadAsStreamAsync())
        //                        {
        //                            using (var image = Image.FromStream(photoStream))
        //                            {
        //                                photoStream.Seek(0, SeekOrigin.Begin);

        //                                if (image.Width > 1000 || image.Height > 1000)
        //                                {
        //                                    int newWidth, newHeight;

        //                                    if (image.Width > image.Height)
        //                                    {
        //                                        newWidth = 1000;
        //                                        newHeight = (int)((float)image.Height / image.Width * newWidth);
        //                                    }
        //                                    else
        //                                    {
        //                                        newHeight = 1000;
        //                                        newWidth = (int)((float)image.Width / image.Height * newHeight);
        //                                    }

        //                                    using (var resizedImage = new Bitmap(image, newWidth, newHeight))
        //                                    {
        //                                        resizedImage.Save(fullFilePath, ImageFormat.Jpeg);
        //                                        totalPhotosResized++;
        //                                    }
        //                                }
        //                                else
        //                                {
        //                                    using (var fileStream = new FileStream(fullFilePath, FileMode.Create))
        //                                    {
        //                                        photoStream.Seek(0, SeekOrigin.Begin);
        //                                        await photoStream.CopyToAsync(fileStream);
        //                                    }
        //                                }

        //                                // Add the photo URL to the HashSet for this model
        //                                modelPhotoUrls[modelValue].Add(photoUrl);
        //                                totalPhotosDownloaded++;
        //                                newPhotosAdded++;
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        wrongUrl.Add(new KeyValuePair<string, string>(modelValue, photoUrl));
        //                        cannotDownload++;
        //                    }
        //                }

        //                // Move to the next row
        //                currentRow = currentRow.RowBelow();
        //            }
        //        }

        //        if (newPhotosAdded == 0)
        //        {
        //            ViewBag.Message = "No new photos added. All photos already exist in the destination folder.";
        //        }
        //        else
        //        {
        //            ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}. Wrong URL, image was not downloaded: {cannotDownload}";
        //            ViewBag.WrongUrl = wrongUrl;
        //        }
        //        System.IO.File.Delete(tempFilePath);
        //    }
        //}
        //catch (Exception ex)
        //{
        //    ViewBag.Message = "An error occurred: " + ex.Message;
        //}

        //return View("DownloadPhotosResult", _resultModel);
    }



    [HttpPost]
    public async Task<ActionResult> DownloadFromXml(int? selectedSupplierXmlSetting, bool renamePhotos, string prefix, string mainPart, string suffix)
    {
        _suppSetting = _gammaContext.MmSupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId == selectedSupplierXmlSetting);
        if (_suppSetting == null)
        {
            ViewBag.MessageNoURL = "Supplier XML setting not found.";
            return View("Index");
        }

        suppName = _gammaContext.MmSuppliers
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
                var photoUrl = photoNode.InnerText;

                string modelValue = null;

                if (_suppSetting.ParamAttribute == null)
                {
                    modelValue = photoNode.SelectSingleNode(_suppSetting.ModelNode)?.InnerText ?? "";
                }
                else
                {
                    modelValue = photoNode.ParentNode.Attributes[_suppSetting.ParamAttribute]?.Value;
                }

                if (!string.IsNullOrEmpty(modelValue))
                {
                    modelValue = SanitizeModelValue(modelValue);

                    if (!modelCount.TryGetValue(modelValue, out int value))
                    {
                        value=0;
                        modelCount[modelValue] = value;
                        modelPhotoUrls[modelValue] = new HashSet<string>();
                        totalPhotoPassedExists++;
                    }
                    modelCount[modelValue]=++value;
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
                    }

                    if (modelPhotoUrls[modelValue].Contains(photoUrl))
                    {
                        totalPhotoPassedExists++;
                        //continue;
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
            }

            ViewBag.Message = $"Total photos downloaded: {totalPhotosDownloaded}. Total photos resized: {totalPhotosResized}. Photos passed because exists {totalPhotoPassedExists}. Can't download. Wrong URL: {imgNameCannotDownload}";
            ViewBag.WrongUrl = wrongUrl;
        }
        catch (Exception ex)
        {
            ViewBag.Message = "An error occurred: " + ex.Message;
        }

        return View("DownloadPhotosResult", _resultModel);
    }


    private string SanitizeModelValue(string modelValue)
    {
        string sanitizedValue = Regex.Replace(modelValue, @"[^a-zA-Z0-9-]", "-");

        sanitizedValue = sanitizedValue.ToLowerInvariant();

        return sanitizedValue;
    }
}
