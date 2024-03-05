using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace xmlParserASP.Controllers;

public class ReplaceInXlColumnController : Controller
{
    // GET: ReplaceInXlColumnController
    public ActionResult Index()
    {
        return View();
    }

    
    // POST: ReplaceInXlColumnController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult ProcessExcel(IFormFile? excelFile, int searchedColumnNumber, int sheetNumber)
    {
        if (excelFile == null || searchedColumnNumber == null || sheetNumber == null)
        {
            ViewBag.Message = "Model, sheet and/or Photo URL column not found in the Excel file.";
            return View("Index");
        }
        try
        {
            string fileFileName = excelFile.FileName;

            string tempFolderPath = Path.GetTempPath();

            string tempFilePath = Path.Combine(tempFolderPath, fileFileName);

            using (var stream = new FileStream(tempFilePath, FileMode.Create))
            {
                excelFile.CopyToAsync(stream);
            }

            using (var workbook = new XLWorkbook(tempFilePath))
            {
                var worksheet = workbook.Worksheet(sheetNumber);
                //var firstRowUsed = worksheet.LastCellUsed(searchedColumnNumber);

                //var currentRow = firstRowUsed.RowUsed().RowBelow(); // Skip the header row



                return View("Result");
            }
        }
        catch
        {
            return RedirectToAction(nameof(Index));
        }
    }
}