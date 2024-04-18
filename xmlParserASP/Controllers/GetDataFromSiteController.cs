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
                    
                    if (!row.Cell(linksColumn).HasHyperlink)
                    {
                        continue;
                    }

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
                            row.Cell(newColumnNumber).Style.Fill.BackgroundColor= XLColor.YellowGreen;
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



                    //_replacementValues.Add((sku, link));
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


    //public void ProcessRowsInColumn(IXLColumn column)
    //{
    //    foreach (var cell in column.CellsUsed())
    //    {
    //        var cellValue = cell.Value.ToString();

    //        if (string.IsNullOrEmpty(cellValue))
    //        {
    //            continue;
    //        }

    //        foreach (var pair in _replacementValues)
    //        {
    //            var oldValue = pair.Key;
    //            var newValue = pair.Value;

    //            cellValue = Regex.Replace(cellValue, Regex.Escape(oldValue), newValue);

    //            if (cellValue != cell.Value.ToString())
    //            {
    //                cell.Value = cellValue;
    //                cell.Style.Fill.BackgroundColor = XLColor.YellowGreen;
    //            }
    //        }
    //    }
    //}
}