using ClosedXML.Excel;
using static xmlParserASP.Services.TranslitMethods;
using System.Xml;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services
{
    public class WriteUaToXL
    {
        private readonly MyDBContext _db;
        public WriteUaToXL(MyDBContext db)
        {
            _db = db;
        }

        public void WriteUaColumnsToXL()
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                IXLWorksheet productsWorksheet = workbook.Worksheets.Add("Products");
                productsWorksheet.SheetView.FreezeRows(1);
                productsWorksheet.Columns().Style.Alignment.WrapText = false;
                IXLRow firstRow = productsWorksheet.Row(1);
                firstRow.Style.Font.Bold = true;


                List<List<string>> productsColumns = new();
                //"model", "supplier_id", "manufacturer",
                productsColumns.Add(new List<string>
                {
                    "product_id", "name(ru-ru)", "name(uk-ua)", "categories", "sku", "upc", "ean", "jan", "isbn", "mpn",
                    "location", "quantity", "model", "manufacturer", "image_name", "shipping", "price", "points",
                    "date_added", "date_modified", "date_available", "unit_id", "weight", "weight_unit", "length",
                    "width",
                    "height", "length_unit", "status", "tax_class_id", "seo_keyword", "description(ru-ru)",
                    "description(uk-ua)", "meta_title(ru-ru)", "meta_title(uk-ua)", "meta_description(ru-ru)",
                    "meta_description(uk-ua)", "meta_keywords(ru-ru)", "meta_keywords(uk-ua)", "stock_status_id",
                    "store_ids", "layout", "related_ids", "tags(ru-ru)", "tags(uk-ua)", "sort_order", "subtract",
                    "minimum",
                    "kd_code", "on_order_status"
                });

                for (int j = 0; j < productsColumns[0].Count; j++)
                {
                    productsWorksheet.Cell(1, j + 1).Value = productsColumns[0][j];
                }

                // Получение индексов столбцов EXCEL на основе их имен
                int product_idColumnIndex = GetColumnIndex(productsWorksheet, "product_id");
                int nameRUColumnIndex = GetColumnIndex(productsWorksheet, "name(ru-ru)");
                int nameUAColumnIndex = GetColumnIndex(productsWorksheet, "name(uk-ua)");
                int categoriesColumnIndex = GetColumnIndex(productsWorksheet, "categories");
                int skuColumnIndex = GetColumnIndex(productsWorksheet, "sku");
                int quantityColumnIndex = GetColumnIndex(productsWorksheet, "quantity");
                int modelColumnIndex = GetColumnIndex(productsWorksheet, "model");
                //int supplier_idColumnIndex = GetColumnIndex(productsWorksheet, "supplier_id");
                int manufacturerColumnIndex = GetColumnIndex(productsWorksheet, "manufacturer");
                int image_nameColumnIndex = GetColumnIndex(productsWorksheet, "image_name");
                int priceColumnIndex = GetColumnIndex(productsWorksheet, "price");
                int date_addedColumnIndex = GetColumnIndex(productsWorksheet, "date_added");
                int date_modifiedColumnIndex = GetColumnIndex(productsWorksheet, "date_modified");
                int date_availableColumnIndex = GetColumnIndex(productsWorksheet, "date_available");
                int seo_keywordColumnIndex = GetColumnIndex(productsWorksheet, "seo_keyword");
                int descriptionRUColumnIndex = GetColumnIndex(productsWorksheet, "description(ru-ru)");
                int descriptionUAColumnIndex = GetColumnIndex(productsWorksheet, "description(uk-ua)");



                XmlDocument xmlDoc = new();
                xmlDoc.Load(PathListVarModel.Path);

                // Настройки выгрузки поставщика

                XmlNodeList itemsList = xmlDoc.GetElementsByTagName(PathListVarModel.XMLProductNode);

                XmlNodeList paramListForCount = xmlDoc.GetElementsByTagName("param");

                int row = 2;
                int startIdFrom = 2255;


                // Получение значений из XML и вставка в соответствующие колонки листа Products

                foreach (XmlNode item in itemsList)
                {
                    startIdFrom++;
                    string product_id = startIdFrom.ToString();
                    string model = item.SelectSingleNode("model")?.InnerText ?? "";
                    string categoryId = item.SelectSingleNode("categoryId")?.InnerText ?? "";
                    string price = item.SelectSingleNode("price")?.InnerText ?? "";
                    string quantity = item.SelectSingleNode("quantity")?.InnerText ?? "";
                    string nameRU = item.SelectSingleNode("name")?.InnerText ?? "";
                    string description = item.SelectSingleNode("description")?.InnerText ?? "";
                    string image = item.SelectSingleNode("image")?.InnerText ?? "";
                    string vendor = item.SelectSingleNode("vendor")?.InnerText ?? "";
                    Translitter trn = new();
                    string seoKeyword = trn.Translit(nameRU, TranslitType.Gost).ToLowerInvariant().Replace(",", "-")
                        .Replace("--", "-").Replace("---", "-").Replace("\'", "");
                    string dateAdded = "2023-07-06 00:00:00";
                    DateTime dateModified = DateTime.Now;
                    string dateAvailable = "2023-07-06 00:00:00";
                    string dateModifiedStr = dateModified.ToString("yyyy-MM-dd HH:mm:ss");
                    string supplier_id = "1";

                    productsWorksheet.Cell(row, product_idColumnIndex).Value = product_id;
                    productsWorksheet.Cell(row, nameRUColumnIndex).Value = nameRU;
                    //productsWorksheet.Cell(row, nameUAColumnIndex).Value = nameRU;
                    productsWorksheet.Cell(row, categoriesColumnIndex).Value = categoryId;
                    productsWorksheet.Cell(row, modelColumnIndex).Value = model;
                    productsWorksheet.Cell(row, manufacturerColumnIndex).Value = vendor;
                    productsWorksheet.Cell(row, image_nameColumnIndex).Value = image;
                    productsWorksheet.Cell(row, priceColumnIndex).Value = price;
                    productsWorksheet.Cell(row, quantityColumnIndex).Value = quantity;
                    //productsWorksheet.Cell(row, supplier_idColumnIndex).Value = supplier_id;
                    productsWorksheet.Cell(row, date_addedColumnIndex).Value = dateAdded;
                    productsWorksheet.Cell(row, date_modifiedColumnIndex).Value = dateModifiedStr;
                    productsWorksheet.Cell(row, date_availableColumnIndex).Value = dateAvailable;

                    productsWorksheet.Cell(row, descriptionRUColumnIndex).Value = description;
                    productsWorksheet.Cell(row, descriptionUAColumnIndex).Value = description;
                    productsWorksheet.Cell(row, seo_keywordColumnIndex).Value = seoKeyword;

                    productsWorksheet.Row(row).Height = 15;
                    row++;


                    //   // Создайте экземпляр модели Product и заполните его данными
                    //        Product product = new Product
                    //        {
                    //            ProductId = int.Parse(product_id),
                    //            SupplierId = int.Parse(supplier_id),

                    //            ProductName = nameRU,
                    //            MyCatId = int.Parse(categoryId),
                    //            model = int.Parse(model),
                    //            quantity = int.Parse(quantity),
                    //            Price =  float.Parse(price),
                    //            image_name = image,
                    //            description = description,
                    //            manufacturer = vendor,
                    //            date_added = dateAdded,
                    //            date_modified = dateModifiedStr,
                    //            date_available = dateAvailable,
                    //            seo_keyword = seoKeyword,
                    //            status = null
                    //        };
                    //    _db.Products.Add(product);
                }
                //_db.SaveChanges();


                var rangeProd = productsWorksheet.Range(productsWorksheet.FirstCellUsed().Address.RowNumber + 1,
                    productsWorksheet.FirstCellUsed().Address.ColumnNumber,
                    productsWorksheet.LastCellUsed().Address.RowNumber,
                    productsWorksheet.LastCellUsed().Address.ColumnNumber);
                rangeProd.Sort();


                // write attributes to sheet
                IXLWorksheet attrWorksheet = workbook.Worksheets.Add("ProductAttributes");

                var array = PathListVarModel.SheetAtributes;


                // duplicates in attributes check

                var uniqueRows = Enumerable.Range(0, array.GetLength(0))
                    .GroupBy(row => $"{array[row, 0]}-{array[row, 2]}", StringComparer.OrdinalIgnoreCase)
                    .Select(g => g.First())
                    .ToArray();


                int numRows = uniqueRows.Length;
                int numCols = array.GetLength(1);

                string[,] newArray = new string[numRows, numCols];

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        newArray[i, j] = array[uniqueRows[i], j];
                    }
                }



                attrWorksheet.SheetView.FreezeRows(1);
                attrWorksheet.Columns().Style.Alignment.WrapText = false;
                IXLRow firstAttrRow = attrWorksheet.Row(1);
                firstAttrRow.Style.Font.Bold = true;

                for (int roww = 0; roww < newArray.GetLength(0); roww++)
                {
                    for (int col = 0; col < newArray.GetLength(1); col++)
                    {
                        attrWorksheet.Cell(roww + 1, col + 1).Value = newArray[roww, col];
                    }
                }

                var rangeAttr = attrWorksheet.Range(attrWorksheet.FirstCellUsed().Address.RowNumber + 1,
                    attrWorksheet.FirstCellUsed().Address.ColumnNumber,
                    attrWorksheet.LastCellUsed().Address.RowNumber,
                    attrWorksheet.LastCellUsed().Address.ColumnNumber);
                rangeAttr.Sort();



                workbook.SaveAs(@"D:\Downloads\output_add_UA.xlsx");

            }
        }
    


        private int GetColumnIndex(IXLWorksheet worksheet, string columnName)
        {

            int columnIndex = 1;

            while (worksheet.Cell(1, columnIndex).Value.ToString() != columnName)
            {
                columnIndex++;
            }

            return columnIndex;
        }
    }
}
