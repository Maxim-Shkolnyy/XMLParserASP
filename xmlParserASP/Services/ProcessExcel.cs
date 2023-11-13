using ClosedXML.Excel;
//using Microsoft.Office.Interop.Excel;

//using Range = Microsoft.Office.Interop.Excel.Range;

namespace xmlParserASP.Services;

static class ProcessExcel
{
    public static string[,] ReadWorksheetToArrayNoPassword(string filePath, int? sheetIndex, int? col1, int? col2, int? col3, int? col4, int? firstRowToRemove, int? lastRowToRemove)  //ClosedXML
    {
        if (sheetIndex == null)
        {
            sheetIndex = 1;
        }
        using (var workbook = new XLWorkbook(filePath))
        {
            var worksheet = workbook.Worksheet((int)sheetIndex);


            if (firstRowToRemove != null)
            {
                if (firstRowToRemove > 0 && lastRowToRemove >= firstRowToRemove)
                {
                    var rangeToRemove = worksheet.Range((int)firstRowToRemove, 1, (int)lastRowToRemove, worksheet.ColumnsUsed().Count());
                    rangeToRemove.Delete(XLShiftDeletedCells.ShiftCellsUp);
                }
            }
            

            var rows = worksheet.RowsUsed();
            int rowCount = rows.Count();
            int allColumnsOnSheetCount = worksheet.ColumnsUsed().Count();
            int columnCount = col1.HasValue ? 1 : 0;
            columnCount += col2.HasValue ? 1 : 0;
            columnCount += col3.HasValue ? 1 : 0;
            columnCount += col4.HasValue ? 1 : 0;
            string[,] dataArray;

            if (columnCount == 0)  // parse all sheet
            {
                dataArray = new string[rows.Count(), allColumnsOnSheetCount];

                for (int rowIdx = 0; rowIdx < dataArray.GetLength(0); rowIdx++)
                {
                    var row = rows.ElementAt(rowIdx);
                    for (int colIdx = 0; colIdx < dataArray.GetLength(1); colIdx++)
                    {
                        dataArray[rowIdx, colIdx] = row.Cell(colIdx + 1).CachedValue.ToString() ?? "";
                    }
                }
            }
            else
            {
                dataArray = new string[rowCount, columnCount];

                for (int rowIdx = 0; rowIdx < rowCount; rowIdx++)
                {
                    var row = rows.ElementAt(rowIdx);
                    int colIdx = 0;
                    if (col1.HasValue)
                        dataArray[rowIdx, colIdx++] = row.Cell(col1.Value + 1).CachedValue.ToString();
                    if (col2.HasValue)
                        dataArray[rowIdx, colIdx++] = row.Cell(col2.Value + 1).CachedValue.ToString();
                    if (col3.HasValue)
                        dataArray[rowIdx, colIdx++] = row.Cell(col3.Value + 1).CachedValue.ToString();
                    if (col4.HasValue)
                        dataArray[rowIdx, colIdx++] = row.Cell(col4.Value + 1).CachedValue.ToString();
                }
            }
            return dataArray;
        }
    }


    public static string[,] GetExcelData(string filePath)
    {
        using (var workbook = new XLWorkbook(filePath))
        {
            var worksheet = workbook.Worksheet(1); // Припускається, що ви хочете прочитати з першого аркуша

            var range = worksheet.RangeUsed();

            int rows = range.RowCount();
            int columns = range.ColumnCount();

            string[,] data = new string[rows, columns];

            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= columns; col++)
                {
                    var cellValue = range.Cell(row, col).Value;

                    if (!string.IsNullOrEmpty(cellValue.ToString()))
                    {
                        data[row - 1, col - 1] = cellValue.ToString();
                    }
                    else
                    {
                        data[row - 1, col - 1] = "";
                    }
                }
            }

            return data;
        }
    }


    //public static string[,] ReadWorksheetToArrayPassword(string filePath, int sheetIndex, int? col1, int? col2, int? col3, int? col4, int firstRowToRemove, int lastRowToRemove, string password)
    //{
    //    Application excelApp = new Application();
    //    Workbook workbook = null;
    //    Worksheet worksheet = null;

    //    try
    //    {
    //        workbook = excelApp.Workbooks.Open(filePath, Password: password);
    //        worksheet = (Worksheet)workbook.Sheets[sheetIndex];

    //        if (firstRowToRemove > 0 && lastRowToRemove >= firstRowToRemove)
    //        {
    //            Range rangeToRemove = worksheet.Range[worksheet.Cells[firstRowToRemove, 1], worksheet.Cells[lastRowToRemove, worksheet.UsedRange.Columns.Count]];
    //            rangeToRemove.Delete(XlDeleteShiftDirection.xlShiftUp);
    //        }

    //        Range usedRange = worksheet.UsedRange;
    //        int rowCount = usedRange.Rows.Count;
    //        int columnCount = usedRange.Columns.Count;
    //        string[,] dataArray = new string[rowCount -1, columnCount -1];

    //        for (int rowIdx = 1; rowIdx <= rowCount; rowIdx++)
    //        {
    //            for (int colIdx = 1; colIdx <= columnCount; colIdx++)
    //            {
    //                dataArray[rowIdx - 1, colIdx - 1] = ((Range)usedRange.Cells[rowIdx, colIdx]).Value?.ToString() ?? "";
    //            }
    //        }

    //        return dataArray;
    //    }
    //    finally
    //    {
    //        if (worksheet != null) Marshal.ReleaseComObject(worksheet);
    //        if (workbook != null) Marshal.ReleaseComObject(workbook);
    //        if (excelApp != null)
    //        {
    //            excelApp.Quit();
    //            Marshal.ReleaseComObject(excelApp);
    //        }
    //    }
    //}
}
