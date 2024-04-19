using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;
using HtmlAgilityPack;
using DocumentFormat.OpenXml.Spreadsheet;

namespace xmlParserASP.Controllers;

public class GetDataFromSiteController : Controller
{
    private List<(string, string)> _replacementValues = new();

    // GET: ReplaceInXlColumnController
    public ActionResult Index()
    {
        return View();
    }


    // POST: ReplaceInXlColumnController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> ProcessExcel(IFormFile? excelFile, int sheetNumber, int skuColumn, int linksColumn, string tag)
    {
        if (excelFile == null)
        {
            ViewBag.Message = "Model, sheet and/or Photo URL column not found in the Excel file.";
            return View("Index");
        }

        string tempFilePath = Path.GetTempFileName();

        try
        {
            using (var workbook = new XLWorkbook(excelFile.OpenReadStream()))
            {
                var workSheet = workbook.Worksheet(sheetNumber);

                int newColumnNumber = workSheet.LastColumnUsed().InsertColumnsAfter(1).First().ColumnNumber();

                string sku, link;                

                foreach (var row in workSheet.RowsUsed())
                {
                    link = row.Cell(linksColumn)?.Value.ToString() ?? "";
                    var hyperlink = row.Cell(linksColumn).GetHyperlink;                     
                    
                    

                    if (!Uri.IsWellFormedUriString(link, UriKind.Absolute))
                    {
                        continue;
                    }

                    HtmlWeb web = new HtmlWeb();
                    HtmlDocument doc = web.Load(link);

                    string linkElement = "";

                    if (doc != null)
                    {
                        var linkElementNode = doc.DocumentNode.SelectSingleNode($"//div[contains(@class, '{tag}')]");

                        if (linkElementNode != null)
                        {
                             linkElement = linkElementNode.InnerText.Trim();

                        }
                        else
                        {
                            row.Cell(newColumnNumber).Style.Fill.BackgroundColor= XLColor.Red;
                        }
                    }
                    else
                    {
                        continue;
                    }

                    if (! string.IsNullOrEmpty(linkElement))
                    {

                        row.Cell(newColumnNumber).Value = linkElement;
                    }
                }

                workbook.SaveAs(tempFilePath);

                byte[] fileBytes = System.IO.File.ReadAllBytes(tempFilePath);
                var fileName = $"{Path.GetFileNameWithoutExtension(excelFile.FileName)}_replaced.xlsx";
                return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
        finally
        {
            if (System.IO.File.Exists(tempFilePath))
            {
                System.IO.File.Delete(tempFilePath);
            }
        }
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> ProcessMyExcelAsync(IFormFile? excelFile, int sheetNumber, int skuColumn, int linksColumn, string tag)
    {
        if (excelFile == null)
        {
            ViewBag.Message = "Model, sheet and/or Photo URL column not found in the Excel file.";
            return View("Index");
        }

        string tempFilePath = Path.GetTempFileName();

        try
        {
            using (var workbook = new XLWorkbook(excelFile.OpenReadStream()))
            {
                var workSheet = workbook.Worksheet(sheetNumber);

                int newColumnNumber = workSheet.LastColumnUsed().InsertColumnsAfter(1).First().ColumnNumber();

                string sku, link;

                await Task.WhenAll(workSheet.RowsUsed().Select(async row =>
                {
                    link = row.Cell(linksColumn)?.Value.ToString() ?? "";
                    var hyperlink = row.Cell(linksColumn).GetHyperlink;

                    if (!Uri.IsWellFormedUriString(link, UriKind.Absolute))
                    {
                        return;
                    }

                    HtmlWeb web = new HtmlWeb();
                    HtmlDocument doc = await web.LoadFromWebAsync(link); // Use asynchronous web loading

                    string linkElement = "";
                    if (doc != null)
                    {
                        var linkElementNode = doc.DocumentNode.SelectSingleNode($"//div[contains(@class, '{tag}')]");

                        if (linkElementNode != null)
                        {
                            linkElement = linkElementNode.InnerText.Trim();
                        }
                        else
                        {
                            row.Cell(newColumnNumber).Style.Fill.BackgroundColor = XLColor.Red;
                        }
                    }

                    if (!string.IsNullOrEmpty(linkElement))
                    {
                        row.Cell(newColumnNumber).Value = linkElement;
                    }
                }));

                workbook.SaveAs(tempFilePath);

                byte[] fileBytes = await System.IO.File.ReadAllBytesAsync(tempFilePath);
                var fileName = $"{Path.GetFileNameWithoutExtension(excelFile.FileName)}_replaced.xlsx";
                return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
        finally
        {
            if (System.IO.File.Exists(tempFilePath))
            {
                System.IO.File.Delete(tempFilePath);
            }
        }
    }

}