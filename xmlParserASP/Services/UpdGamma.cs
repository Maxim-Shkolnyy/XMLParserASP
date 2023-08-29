//using ClosedXML.Excel;
//using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using System;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using xmlParserASP.Models;
using xmlParserASP.Services;
using Range = Microsoft.Office.Interop.Excel.Range;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace xmlParserASP.Services
{
    public class UpdGamma
    {
        public void RunUpdateMethods()
        {
            FModel.vygruzkaNalichiyeAllFileInfo = GetNewestFileInfo(FModel.dDownloadsTelegramPath, FModel.nalichuyeFile);
            FModel.vygruzkaOpencartFileInfo = GetNewestFileInfo(FModel.dDownloadsPath, FModel.opencartVygruzkaFilenaneStartsWith);
            //FModel.vygruzkaPromFileInfo = GetNewestFileInfo(FModel.dDownloadsPath, FModel.prom);

            FModel.opecartPath = FModel.vygruzkaOpencartFileInfo?.FullName;
            // FModel.promPath = FModel.vygruzkaPromFileInfo.FullName;

            if (FModel.vygruzkaNalichiyeAllFileInfo == null)
            {
                Console.WriteLine("No files matching \"Nalichiye dlya saytov\" were found.");
            }
            else if (FModel.FLa888Path == null)
            {
                Console.WriteLine("No files matching \"F-la 888_NEW12 .xlsx\" were found.");
            }
            else
            {
                CopyDataToFLa888();


                //if (FModel.opencartVygruzkaFilenaneStartsWith.Contains("export-products"))
                //{
                //    DataToProm dataToProm = new();
                //    dataToProm.xlookupToProm();
                //}
                //else
                //{
                    DataToOpencart dataToOpencart = new();
                    dataToOpencart.XLookupToOpencart();
                //}
            }
        }

        static void CopyDataToFLa888()
        {
            Application excelApp = new Application();
            Workbook vygruzkaAnny = excelApp.Workbooks.Open(FModel.vygruzkaNalichiyeAllFileInfo.FullName, Password: FModel.password);
            Worksheet sourceWorksheet = vygruzkaAnny.ActiveSheet;
            Range deleteRange = sourceWorksheet.Range["1:8"];
            deleteRange.Delete(XlDeleteShiftDirection.xlShiftUp);

            // Copy the data from source sheet
            int lastRow = sourceWorksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
            Range sourceRange = sourceWorksheet.Range["A1:AD" + lastRow];
            object[,] data = sourceRange.Value;

            // Close the source file
            vygruzkaAnny.Close(SaveChanges: false);
            excelApp.Quit();

            // Open the target file
            excelApp = new Application();
            Workbook f_laFile888 = excelApp.Workbooks.Open(FModel.FLa888Path);
            Worksheet fLa888Worksheet1 = f_laFile888.Worksheets[1];

            // Paste the data to target sheet
            Range targetRange = fLa888Worksheet1.Range["B9:AE" + lastRow];
            targetRange.Value = data;

            var FLA = fLa888Worksheet1.UsedRange;
            object[,] flaValues = FLA.Value;




            f_laFile888.Save();
            f_laFile888.Close(SaveChanges: true);
            //f_laFile888.SaveAs("Ф-ла 888_NEW12 .xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value, Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, false, Missing.Value, Missing.Value, Missing.Value);

            excelApp.Quit();
            Console.WriteLine($"Data to 'F-la 888_NEW12' copied successfully from Vygruzka nalichiya {FModel.vygruzkaNalichiyeAllFileInfo.CreationTime}");
        }


        static FileInfo? GetNewestFileInfo(string path, string filename)
        {
            return Directory.GetFiles(path, $"{filename}*")
                 .Where(f => Path.GetFileName(f).StartsWith(filename))
                 .Select(f => new FileInfo(f))
                 .OrderByDescending(f => f.CreationTime)
                 .FirstOrDefault();
        }

        public static void CopyData()
        {
            using (var vygruzkaAnny = new XLWorkbook(FModel.vygruzkaNalichiyeAllFileInfo.FullName))
            using (var f_laFile888 = new XLWorkbook(FModel.FLa888Path))
            {
                var sourceWorksheet = vygruzkaAnny.Worksheet(1);
                var targetWorksheet = f_laFile888.Worksheet(1);

                sourceWorksheet.Range("1:8").Delete(XLShiftDeletedCells.ShiftCellsUp);

                int lastRow = sourceWorksheet.LastRowUsed().RowNumber();
                int lastColumn = sourceWorksheet.LastColumnUsed().ColumnNumber();

                var sourceRange = sourceWorksheet.Range($"A1:{XLHelper.GetColumnLetterFromNumber(lastColumn)}{lastRow}");
                var targetRange = targetWorksheet.Range("B9");

                var data = sourceRange.CellsUsed().Select(s  => s.Value).ToArray();
                //object[,] dataArray = ExcelRangeToArray.ReadRangeToArray(filePath, sheetName, range);

                // Copy data cell by cell
                for (int row = 1; row <= lastRow; row++)
                {
                    for (int col = 1; col <= lastColumn; col++)
                    {
                        var cellValue = sourceRange.Cell(row, col).Value;
                        targetRange.Cell(row, col).Value = cellValue;
                    }
                }

                f_laFile888.Save();
            }

            Console.WriteLine($"Data copied successfully from Vygruzka nalichiya {FModel.vygruzkaNalichiyeAllFileInfo.CreationTime}");
        }

        public class DataToOpencart
        {
            private Dictionary<int, string> opencartDict = new();
            private Dictionary<int, string> fLaDict = new();
            private Dictionary<int, string> codesWhereQuantityAlwaysTen = new();
            private string[,] fullDataOpencartString2Array;

            public void XLookupToOpencart()
            {
                using (var opencartFile = new XLWorkbook(FModel.opecartPath))
                using (var fLaFile = new XLWorkbook(FModel.FLa888Path))
                {
                    var opencartWSheet1 = opencartFile.Worksheet(1);
                    var fLaFileWSheet1 = fLaFile.Worksheet(1);

                    // Rest of the code...

                    ParseDataFromOpencartToDictionaries();
                    ParseDataFromOpencartTo2DArray();
                    ParseDataFromFormulaToQuantityDictionary();

                    // Rest of the code...
                }
            }

            private void ParseDataFromOpencartTo2DArray()
            {
                // Rest of the code...
            }

            private void ParseDataFromOpencartToDictionaries()
            {
                // Rest of the code...
            }

            private void ParseDataFromFormulaToQuantityDictionary()
            {
                // Rest of the code...
            }

            private void CompareAndInsertDataToOpencart()
            {
                using (var opencartFile = new XLWorkbook(FModel.opecartPath))
                {
                    var opencartWSheet1 = opencartFile.Worksheet(1);

                    // Rest of the code...

                    //opencartFile.SaveAs(updatedFilePath);
                }
            }
        }
    }

}

