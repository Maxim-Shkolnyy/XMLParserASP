using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using xmlParserASP.Models;

namespace xmlParserASP.Services
{
    public class UpdGamma
    {
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

                    opencartFile.SaveAs(updatedFilePath);
                }
            }
        }
    }

}
}
