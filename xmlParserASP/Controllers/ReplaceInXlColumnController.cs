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
    public async Task<ActionResult> ProcessExcel(IFormFile? excelFileWhereReplace, IFormFile? excelFileReplacementMask, int searchedSheetNumber, int replacementSheetNumber, int searchedColumn, int oldReplacementColumn, int newReplacementColumn)
    {
        if (excelFileWhereReplace == null || excelFileReplacementMask == null)
        {
            ViewBag.Message = "Model, sheet and/or Photo URL column not found in the Excel file.";
            return View("Index");
        }

        try
        {
            string searchedFileName = $"{excelFileWhereReplace.FileName}_{DateTime.Now.Ticks}";
            string replacedMaskFileName = $"{excelFileReplacementMask.FileName}_{DateTime.Now.Ticks}";
            string tempFolderPath = Path.GetTempPath();
            string tempSearchedFilePath = Path.Combine(tempFolderPath, searchedFileName);
            string tempReplacementFilePath = Path.Combine(tempFolderPath, replacedMaskFileName);

            using (var stream = new FileStream(tempSearchedFilePath, FileMode.Create))
            {
                await excelFileReplacementMask.CopyToAsync(stream);
            }


            using (var stream = new FileStream(tempReplacementFilePath, FileMode.Create))
            {
                await excelFileWhereReplace.CopyToAsync(stream);
            }

            using (var workbook = new XLWorkbook(tempSearchedFilePath))
            {
                //var rowsUsed = worksheet.LastRowUsed()?.RowNumber() ?? 0;
                //var cellsUsed = worksheet.LastCellUsed()?.Address.ColumnNumber ?? 0;
                var worksheet = workbook.Worksheet(searchedSheetNumber);

                if (searchedColumn <= 0)
                {
                    foreach (var column in worksheet.ColumnsUsed())
                    {
                        ProcessRowsInColumn(column);
                    }
                }
                else
                {
                    ProcessRowsInColumn(worksheet.Column(searchedColumn));
                }
            }

            return View("Result");
        }
        catch (Exception ex)
        {
            ViewBag.Message = "An error occurred while processing the Excel file.";
            return View("Index");
        }
    }

    public void ProcessRowsInColumn(IXLColumn column)
    {
        foreach (var cell in column.CellsUsed())
        {

        }

    }

}