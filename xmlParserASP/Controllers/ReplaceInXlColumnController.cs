﻿using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;

namespace xmlParserASP.Controllers;

public class ReplaceInXlColumnController : Controller
{
    private Dictionary<string, string> _replacementValues = new();

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

        string tempFilePath = Path.GetTempFileName();

        try
        {
            using (var replacementWorkbook = new XLWorkbook(excelFileReplacementMask.OpenReadStream()))
            {
                var replacementWorkSheet = replacementWorkbook.Worksheet(replacementSheetNumber);

                string oldValue, newValue;

                foreach (var row in replacementWorkSheet.RowsUsed())
                {
                    oldValue = row.Cell(oldReplacementColumn)?.Value.ToString() ?? "";
                    newValue = row.Cell(newReplacementColumn)?.Value.ToString() ?? "";

                    if (string.IsNullOrEmpty(oldValue))
                    {
                        continue;
                    }

                    if (!_replacementValues.TryAdd(oldValue, newValue))
                    {
                        Console.WriteLine($"Duplicate replacement value {oldValue}, row {row.RowNumber()}");
                    }
                }
            }

            using (var workbook = new XLWorkbook(excelFileWhereReplace.OpenReadStream()))
            {
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

                workbook.SaveAs(tempFilePath);
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(tempFilePath);
            var fileName = $"{Path.GetFileNameWithoutExtension(excelFileWhereReplace.FileName)}_replaced.xlsx";
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        finally
        {
            if (System.IO.File.Exists(tempFilePath))
            {
                System.IO.File.Delete(tempFilePath);
            }

        }


    }
    

    public void ProcessRowsInColumn(IXLColumn column)
    {
        foreach (var cell in column.CellsUsed())
        {
            var cellValue = cell.Value.ToString();

            if (string.IsNullOrEmpty(cellValue))
            {
                continue;
            }

            foreach (var pair in _replacementValues)
            {
                var oldValue = pair.Key;
                var newValue = pair.Value;

                cellValue = Regex.Replace(cellValue, Regex.Escape(oldValue), newValue);

                if (cellValue != cell.Value.ToString())
                {
                    cell.Value = cellValue;
                    cell.Style.Fill.BackgroundColor = XLColor.YellowGreen;
                }
            }
        }
    }
}