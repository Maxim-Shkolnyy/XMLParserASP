using ClosedXML.Excel;

namespace xmlParserASP.Services
{
    public class UpdGamma
    {
        public void CopyData()
        {
            using (var vygruzkaAnny = new XLWorkbook(FModel.vygruzkaNalichiyeAllFileInfo.FullName))
            using (var f_laFile888 = new XLWorkbook(FModel.FLa888Path))
            {
                var sourceWorksheet = vygruzkaAnny.Worksheet(1);
                var targetWorksheet = f_laFile888.Worksheet(1);

                sourceWorksheet.Range("1:8").Delete(XLShiftDeletedCells.ShiftUp);

                int lastRow = sourceWorksheet.LastRowUsed().RowNumber();
                var sourceRange = sourceWorksheet.Range($"A1:AD{lastRow}");
                var data = sourceRange.RangeUsed().AsTable().DataRange.ToArray();

                int targetLastRow = targetWorksheet.LastRowUsed().RowNumber();
                var targetRange = targetWorksheet.Range($"B9:AE{targetLastRow}");
                targetRange.Clear(XLClearOptions.Contents);

                targetRange.Cell(1, 1).InsertData(data);

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
