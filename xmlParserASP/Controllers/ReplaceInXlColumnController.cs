using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;

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
    public ActionResult ProcessExcel(IFormFile excelFile)
    {
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
                var worksheet = workbook.Worksheet(1);
                //var firstRowUsed = worksheet.LastCellUsed(serchedColumn);

                //if (modelColumn == null || photoUrlColumn == null || worksheet == null)
                //{
                //    ViewBag.Message = "Model, sheet and/or Photo URL column not found in the Excel file.";
                //    return View("Index");
                //}

                //var currentRow = firstRowUsed.RowUsed().RowBelow(); // Skip the header row



                return View("Result");
        }
        catch
        {
            return RedirectToAction(nameof(Index));
        }
    }
}