using Microsoft.Office.Interop.Excel;
using xmlParserASP.Models;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Excel_test
{
    public class DataToOpencart
    {
        private Range opencartRange;
        private Range fLaRange;
        private object[,] opencartValues;
        private object[,] fLaValues;
        private Dictionary<int, string> opencartDict = new();
        private Dictionary<int, string> fLaDict = new();
        private Dictionary<int, string> codesWhereQuantityAlwaysTen = new();
        private Worksheet opencartWSheet1;
        private Workbook opencartFile;
        private Workbook fLaFile;
        private Range insertedOpencartRange;
        private int opencartRowCount;
        private int columnsCount;
        string[,] fullDataOpencartString2Array;


        public void xlookupToOpencart()
        {

            Application excelApp = new Application();
            opencartFile = excelApp.Workbooks.Open(FModel.opecartPath);
            opencartWSheet1 = opencartFile.Worksheets[1];

            fLaFile = excelApp.Workbooks.Open(FModel.FLa888Path);
            Worksheet fLaFileWSheet1 = fLaFile.Worksheets[1];

            fLaRange = fLaFileWSheet1.UsedRange;
            fLaValues = fLaRange.Value;

            opencartRange = opencartWSheet1.UsedRange;
            opencartValues = opencartRange.Value;
            opencartRowCount = opencartRange.Rows.Count;
            columnsCount = opencartRange.Columns.Count;

            insertedOpencartRange = opencartWSheet1.Range[opencartWSheet1.Cells[2, FModel.quantityOpencartColumn],
                opencartWSheet1.Cells[opencartRowCount, FModel.quantityOpencartColumn]].End[XlDirection.xlUp];

            try
            {

                ParsingFromOpencartToDictCodeAndCategoryAndOtherDictCatogryAlwaysTen();
                ParsingFromOpencartTo2Array();
                try
                {
                    ParsingFromFormulaToDictCodesAndQuantity();
                }
                catch
                {
                    Console.WriteLine(
                        $"Probably, duplicates in codes of F-la888 NEW .xlsx data. Dictionary don`n may have duplicates!!! \n Rows after contained duplicate was not processed");
                }
                CompareAndInsertDataToOpencart();
                excelApp.Quit();
                Console.WriteLine($"\n \nQuantity on {FModel.opecartPath} vas updated");
                // Marshal.ReleaseComObject(excelApp);
            }
            catch
            {
                opencartFile.Close(SaveChanges: false);
                fLaFile.Close(SaveChanges: false);
                excelApp.Quit();

                Console.WriteLine("\n \nData NOT added ! ! ! ");
                // Marshal.ReleaseComObject(excelApp);
            }
        }

        public void ParsingFromOpencartTo2Array()
        {
            int rows = opencartValues.GetLength(0);
            int cols = opencartValues.GetLength(1);
            fullDataOpencartString2Array = new string[rows - 1, cols - 1];

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (opencartValues[i, j] is int)
                    {
                        fullDataOpencartString2Array[i - 1, j - 1] = opencartValues[i, j].ToString();
                    }
                    else if (opencartValues[i, j] is bool)
                    {
                        fullDataOpencartString2Array[i - 1, j - 1] = ((bool)opencartValues[i, j]) ? "yes" : "no";
                    }
                    else if (opencartValues[i, j] is string)
                    {
                        fullDataOpencartString2Array[i - 1, j - 1] = (opencartValues[i, j].ToString());
                    }
                    else
                    {
                        fullDataOpencartString2Array[i - 1, j - 1] = opencartValues[i, j]?.ToString() ?? string.Empty;
                    }
                }
            }
        }


        public void ParsingFromOpencartToDictCodeAndCategoryAndOtherDictCatogryAlwaysTen()
        {
            int code;
            string categoryString = null;
            string category = "0";
            int wrongOpencartCode = 0;

            for (int row = 2; row <= opencartRange.Rows.Count; row++)
            {
                category = opencartValues[row, FModel.categoryOpencartColumn].ToString();
                bool codeBool = int.TryParse(opencartValues[row, FModel.codeOpencartColumn]?.ToString(), out code);
                categoryString = opencartValues[row, FModel.categoryOpencartColumn]?.ToString();

                // if (!codeBool || !catBool)
                if (!codeBool)
                {
                    if (!codeBool)
                    {
                        wrongOpencartCode--;
                        opencartDict.Add(wrongOpencartCode, category);
                    }
                    else
                    {
                        opencartDict.Add(code, "0");
                    }

                    Console.WriteLine(
                        $"PROBLEM{wrongOpencartCode} in {FModel.opecartPath} on line {row}, code {code}, insertedValue {category}, category {categoryString}");
                    continue;
                }

                opencartDict.Add(code, category);

                if (categoryString == FModel.categoryVyvisky.ToString() || categoryString == FModel.categoryDerevBalka.ToString())
                {
                    codesWhereQuantityAlwaysTen.Add(code, "10");
                }
            }

            Console.WriteLine(
                $"Data from {FModel.opecartPath} copied to program. Count rows = {opencartDict.Count} \n Products with categorys always min 10: {codesWhereQuantityAlwaysTen.Count}  ");
        }


        public void ParsingFromFormulaToDictCodesAndQuantity()
        {
            int wrongCode = 0;
            
                for (int row = 12;
                     row <= fLaRange.Rows.Count;
                     row++) // for (int row = 12; row <= fLaRange.Rows.Count; row++)
                {
                    int code;
                    string insertedQuantityValue = null;

                    bool codeBool = int.TryParse(fLaValues[row, FModel.flaCodeColumn]?.ToString(), out code);

                    if (!codeBool)
                    {
                        wrongCode--;
                        fLaDict.Add(wrongCode, insertedQuantityValue);
                        // Console.WriteLine($"PROBLEM {wrongCode} in 'F-la888' on line {row}, code {code}, isertedValue {insertedQuantityValue}"); //Считает и последние пустые строки, нужен только для отладки
                        continue;
                    }

                    if (codesWhereQuantityAlwaysTen.ContainsKey(code))
                    {
                        fLaDict.Add(code, "10");
                        continue;
                    }

                    double quantityDouble;
                    bool valueBoll = double.TryParse(fLaValues[row, FModel.flaQuantityColumn]?.ToString(),
                        out quantityDouble);
                    if (valueBoll)
                    {
                        int roundedQuantity = (int)Math.Floor(quantityDouble);
                        insertedQuantityValue = roundedQuantity.ToString();
                    }
                    else
                    {
                        insertedQuantityValue = quantityDouble.ToString();
                    }

                    fLaDict.Add(code, insertedQuantityValue);
                }

                Console.WriteLine(
                    $"F-la888 NEW .xlsx data copied. Last code was {fLaDict.Keys.Last()}. Count {fLaDict.Count}");
                      
        }


        private void CompareAndInsertDataToOpencart()
        {
            int filledCount = 0;
            string quantityFromFla = null;

            for (int row = 2; row <= opencartRowCount; row++)
            {
                int code = Convert.ToInt32(opencartWSheet1.Cells[row, FModel.codeOpencartColumn].Value);
                int value = Convert.ToInt32(opencartWSheet1.Cells[row, FModel.codeOpencartColumn].Value);


                if (codesWhereQuantityAlwaysTen.ContainsKey(code))
                {
                    opencartWSheet1.Cells[row, FModel.quantityOpencartColumn] = "10";
                    continue;
                }

                if (fLaDict.TryGetValue(code, out quantityFromFla))
                {

                    opencartWSheet1.Cells[row, FModel.quantityOpencartColumn] = quantityFromFla;
                    opencartWSheet1.Cells[row, FModel.quantityOpencartColumn].Interior.ColorIndex = 6;
                    filledCount++;

                }
                else
                {
                    opencartWSheet1.Cells[row, FModel.quantityOpencartColumn] = 0;
                    opencartWSheet1.Cells[row, FModel.quantityOpencartColumn].Interior.ColorIndex = 3;
                    filledCount++;
                }

                // вывод процента заполнения файла в консоль каждые 100 строк
                double progress = (double)(row) / (opencartRowCount - 1) * 100;
                if (row >= opencartRowCount -1)
                    progress = 100;
                Console.Write($"\rData coping to {FModel.opecartPath} Processing: {progress:f2}% ");

            }
            string originalFileName = opencartFile.FullName;
            string updatedFileName = Path.GetFileNameWithoutExtension(originalFileName) + "_upd" +
                                     Path.GetExtension(originalFileName);
            string updatedFilePath = Path.Combine(FModel.dDownloadsPath, updatedFileName);
            opencartFile.SaveAs(updatedFilePath);
            opencartFile.Close();
            //File.Delete(originalFileName);
        }

        private void CompareAndInsertDataToOpencartNotWork()
        {
            string quantityFromFla = null;
            object[,] objectArray = new object[fullDataOpencartString2Array.GetLength(0), fullDataOpencartString2Array.GetLength(1)];

            for (int row = 2; row < fullDataOpencartString2Array.GetLength(0); row++)
            {

                int code = Convert.ToInt32(fullDataOpencartString2Array[row, FModel.codeOpencartColumn -1]);
                int value = Convert.ToInt32(fullDataOpencartString2Array[row, FModel.codeOpencartColumn -1]);


                if (codesWhereQuantityAlwaysTen.ContainsKey(code))
                {
                    fullDataOpencartString2Array[row, FModel.quantityOpencartColumn] = "10";
                    continue;
                }

                if (fLaDict.TryGetValue(code, out quantityFromFla))
                {
                    fullDataOpencartString2Array[row, FModel.quantityOpencartColumn] = quantityFromFla;
                }
                else
                {
                    fullDataOpencartString2Array[row, FModel.quantityOpencartColumn] = "0";
                }

                opencartValues = fullDataOpencartString2Array;
                Range range = opencartWSheet1.Range[
                    opencartWSheet1.Cells[1, 1],
                    opencartWSheet1.Cells[fullDataOpencartString2Array.GetLength(0), fullDataOpencartString2Array.GetLength(1)]
                ];



                for (int i = 0; i < fullDataOpencartString2Array.GetLength(0); i++)
                {
                    for (int j = 0; j < fullDataOpencartString2Array.GetLength(1); j++)
                    {
                        objectArray[i, j] = fullDataOpencartString2Array[i, j];
                    }
                }

                // Устанавливаем значение Range равным массиву fullDataOpencartString2Array
                //range.NumberFormat = "@";
                range.Value = objectArray;



                // вывод процента заполнения файла в консоль каждые 100 строк
                double progress = (double)(row) / (fullDataOpencartString2Array.GetLength(0) - 1) * 100;
                if (row == fullDataOpencartString2Array.GetLength(0) - 1)
                    progress = 100;
                Console.Write($"\rData coping to {FModel.opecartPath} Processing: {progress:f2}% ");
            }

            string originalFileName = opencartFile.FullName;
            string updatedFileName = Path.GetFileNameWithoutExtension(originalFileName) + "_upd" +
                                     Path.GetExtension(originalFileName);
            string updatedFilePath = Path.Combine(FModel.dDownloadsPath, updatedFileName);
            opencartFile.SaveAs(updatedFilePath);
            opencartFile.Close();
            //File.Delete(originalFileName);
        }
    }

}


