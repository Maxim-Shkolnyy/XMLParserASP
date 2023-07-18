using System.Xml;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using xmlParserASP.Entities;
using xmlParserASP.Entities.GammaTables.MyTempToGamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using static xmlParserASP.Services.TranslitMethods;

namespace xmlParserASP.Services;

public class WriteToXL
{
    private readonly MyDBContext _db;
    
    public WriteToXL(MyDBContext db)
    {
        _db = db;
    }
    public void WriteSheet()
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
                "date_added", "date_modified", "date_available", "unit_id", "weight", "weight_unit", "length", "width",
                "height", "length_unit", "status", "tax_class_id", "seo_keyword", "description(ru-ru)",
                "description(uk-ua)", "meta_title(ru-ru)", "meta_title(uk-ua)", "meta_description(ru-ru)",
                "meta_description(uk-ua)", "meta_keywords(ru-ru)", "meta_keywords(uk-ua)", "stock_status_id",
                "store_ids", "layout", "related_ids", "tags(ru-ru)", "tags(uk-ua)", "sort_order", "subtract", "minimum",
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
            int statusColumnIndex = GetColumnIndex(productsWorksheet, "status");
            int date_addedColumnIndex = GetColumnIndex(productsWorksheet, "date_added");
            int date_modifiedColumnIndex = GetColumnIndex(productsWorksheet, "date_modified");
            int date_availableColumnIndex = GetColumnIndex(productsWorksheet, "date_available");
            int seo_keywordColumnIndex = GetColumnIndex(productsWorksheet, "seo_keyword");
            int descriptionRUColumnIndex = GetColumnIndex(productsWorksheet, "description(ru-ru)");
            int descriptionUAColumnIndex = GetColumnIndex(productsWorksheet, "description(uk-ua)");



            XmlDocument xmlDoc = new();
            xmlDoc.Load(PathModel.Path);

            // Настройки выгрузки поставщика

            XmlNodeList itemsList = xmlDoc.GetElementsByTagName(PathModel.XMLProductNode);
            
            //XmlNodeList paramListForCount = xmlDoc.GetElementsByTagName(PathModel.XMLParamNode);

            int row = 2;
            int startIdFrom = PathModel.StartGammaIDFrom;

            
            #region Получение значений из XML и вставка в соответствующие колонки листа Products

            foreach (XmlNode item in itemsList)
            {
                startIdFrom++;
                string product_id = startIdFrom.ToString();
                //string model = item.SelectSingleNode(PathModel.XMLModelNode)?.InnerText ?? "";
                string model = item.Attributes["id"]?.Value;

                string categoryId = item.SelectSingleNode("categoryId")?.InnerText ?? "";
                string price = item.SelectSingleNode("price")?.InnerText ?? "";
                string quantity = item.SelectSingleNode(PathModel.XMLQuantityNode)?.InnerText ?? "";
                string nameUA = item.SelectSingleNode("name")?.InnerText ?? "";
                string description = item.SelectSingleNode("description")?.InnerText ?? "";
                string image = item.SelectSingleNode(PathModel.XMLPictureNode)?.InnerText ?? "";
                string vendor = item.SelectSingleNode(PathModel.XMLSupplierNode)?.InnerText ?? "";
                Translitter trn = new();
                string firstKeyword = trn.Translit(nameUA, TranslitType.Gost).ToLowerInvariant().Replace(",", "-")
                    .Replace("--", "-").Replace("---", "-").Replace("\'", "").Replace("\"", "");
                string seoKeyword = firstKeyword.Replace("--", "-");
                string dateAdded = "2023-07-06 00:00:00";
                DateTime dateModified = DateTime.Now;
                string dateAvailable = "2023-07-06 00:00:00";
                string dateModifiedStr = dateModified.ToString("yyyy-MM-dd HH:mm:ss");
                string supplier_id = "1"; 


                // ------------------------------------

                //var modelCount = new Dictionary<string, int>();

                //var photoNodes = xmlDoc.SelectNodes($"//{PathModel.XMLPictureNode}");


                //foreach (XmlNode photoNode in photoNodes)
                //{
                //    var photoUrl = photoNode.InnerText;

                //    // Get the model value from the parent node
                //    var modelNode = photoNode.ParentNode.SelectSingleNode(PathModel.XMLModelNode);
                //    var modelValue = modelNode?.InnerText;

                //    // Extract the original file name from the URL
                //    var originalFileName = Path.GetFileName(photoUrl);

                //    // Check if the model exists in the dictionary
                //    if (!modelCount.ContainsKey(modelValue))
                //    {
                //        // Add the model to the dictionary with an initial count of 0
                //        modelCount[modelValue] = 0;
                //    }

                //    // Increment the count for the model
                //    modelCount[modelValue]++;

                //    // Get the count value for the model
                //    var count = modelCount[modelValue];

                //    // If the count is already greater than 0, skip downloading the photo
                //    if (count > 0)
                //    {
                //        continue;
                //    }

                //    // Increment the count for the model
                //    modelCount[modelValue]++;

                // Get the alphabetic character based on the count (A, B, C, ...)
                //var alphabeticCharacter = ((char)('A' + count - 1)).ToString();
                var imageAdress = image.Split("/").Last();
                var imageName = $"catalog/image/{model}-A-{PathModel.Supplier}_{imageAdress}";
               // var imageName = imageAdress.Split("/").Last();
                    //PathModel.imageNameInCatImg = $"catalog/image/{imageName}";
                //}
                // ---------------------

                productsWorksheet.Cell(row, product_idColumnIndex).Value = model;
                productsWorksheet.Cell(row, nameRUColumnIndex).Value = "-";
                productsWorksheet.Cell(row, nameUAColumnIndex).Value = nameUA;
                productsWorksheet.Cell(row, categoriesColumnIndex).Value = categoryId;
                productsWorksheet.Cell(row, modelColumnIndex).Value = model;
                productsWorksheet.Cell(row, manufacturerColumnIndex).Value = vendor;
                //productsWorksheet.Cell(row, image_nameColumnIndex).Value = image;
                productsWorksheet.Cell(row, image_nameColumnIndex).Value = imageName;

                productsWorksheet.Cell(row, priceColumnIndex).Value = price;
                productsWorksheet.Cell(row, quantityColumnIndex).Value = quantity;
                productsWorksheet.Cell(row, statusColumnIndex).Value = "true";
                //productsWorksheet.Cell(row, supplier_idColumnIndex).Value = supplier_id;
                productsWorksheet.Cell(row, date_addedColumnIndex).Value = dateAdded;
                productsWorksheet.Cell(row, date_modifiedColumnIndex).Value = dateModifiedStr;
                productsWorksheet.Cell(row, date_availableColumnIndex).Value = dateAvailable;

                productsWorksheet.Cell(row, descriptionRUColumnIndex).Value = "-";
                productsWorksheet.Cell(row, descriptionUAColumnIndex).Value = description;
                productsWorksheet.Cell(row, seo_keywordColumnIndex).Value = seoKeyword;

                productsWorksheet.Row(row).Height = 15;
                row++;
                   
                //        Product product = new Product
                //        {ProductId = int.Parse(product_id), SupplierId = int.Parse(supplier_id), ProductName = nameRU, MyCatId = int.Parse(categoryId), model = int.Parse(model), quantity = int.Parse(quantity), Price =  float.Parse(price), image_name = image, description = description, manufacturer = vendor, date_added = dateAdded, date_modified = dateModifiedStr, date_available = dateAvailable, seo_keyword = seoKeyword, status = null};
                //    _db.Products.Add(product);
            }
            //_db.SaveChanges();
                

            var rangeProd = productsWorksheet.Range(productsWorksheet.FirstCellUsed().Address.RowNumber + 1,
                productsWorksheet.FirstCellUsed().Address.ColumnNumber,
                productsWorksheet.LastCellUsed().Address.RowNumber,
                productsWorksheet.LastCellUsed().Address.ColumnNumber);
            rangeProd.Sort();
            #endregion

                #region ProductAttributes
                // write attributes to sheet
                IXLWorksheet attrWorksheet = workbook.Worksheets.Add("ProductAttributes");

                var array = PathModel.SheetAtributes;

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
                #endregion

                #region Categories

                IXLWorksheet uniqCatSheet = workbook.Worksheets.Add("Categories");

                uniqCatSheet.SheetView.FreezeRows(1);
                uniqCatSheet.Columns().Style.Alignment.WrapText = false;
                IXLRow firstCatRow = uniqCatSheet.Row(1);
                firstCatRow.Style.Font.Bold = true;

                uniqCatSheet.Cell(1, 1).Value = "Cat ID";
                uniqCatSheet.Cell(1, 2).Value = "Cat name";

                XmlNodeList categoryNodes = xmlDoc.SelectNodes("//category");

                int rowNum = 1;
                foreach (XmlNode categoryNode in categoryNodes)
                {
                    string id = categoryNode.Attributes["id"]?.Value ?? "";
                    string name = categoryNode.InnerText.Trim();

                    uniqCatSheet.Cell(rowNum + 1, 1).Value = id;
                    uniqCatSheet.Cell(rowNum +1, 2).Value = name;

                    rowNum++;
                }
                #endregion


                #region Adding uniq Attributes to sheets

                IXLWorksheet uniqAttrSheet = workbook.Worksheets.Add("Attributes");

                uniqAttrSheet.SheetView.FreezeRows(1);
                uniqAttrSheet.Columns().Style.Alignment.WrapText = false;
                IXLRow firstAtrRow = uniqAttrSheet.Row(1);
                firstAtrRow.Style.Font.Bold = true;

                int rowAttrib = 2;

                uniqAttrSheet.Cell(1, 1).Value = "Attr ID";
                uniqAttrSheet.Cell(1, 2).Value = "Attribute name";

                var paramNames = new HashSet<string>();
                var paramIndex = 1;
                var paramId = 1;

                foreach (XmlNode item in itemsList)
                {
                    XmlNodeList paramList = item.SelectNodes(PathModel.XMLParamNode);

                    foreach (XmlNode param in paramList)
                    {
                        string paramName = param.Attributes["name"]?.Value;

                        // Add the param name to the HashSet if it doesn't already exist
                        if (!paramNames.Contains(paramName))
                        {
                            paramNames.Add(paramName);

                            // Output the param name to Excel worksheet
                            uniqAttrSheet.Cell(paramIndex + 1, 1).Value = paramId;
                            uniqAttrSheet.Cell(paramIndex + 1, 2).Value = paramName;
                            
                            paramIndex++;
                            paramId++;
                        }
                    }

                    //itemIndex++;
                }


                //var paramValues = new HashSet<string>();
                //var paramIndex = 1;
                //foreach (XmlNode item in itemsList)
                //{
                //    XmlNodeList paramList = item.SelectNodes(PathModel.XMLParamNode);

                //    foreach (XmlNode param in paramList)
                //    {
                //        string paramValue = param.InnerText;

                //        // Add the param value to the HashSet if it doesn't already exist
                //        if (!paramValues.Contains(paramValue))
                //        {
                //            paramValues.Add(paramValue);

                //            // Output the param value to Excel worksheet
                //            uniqAttrSheet.Cell(paramIndex + 1, 1).Value = paramValue;
                //            paramIndex++;
                //        }
                //    }

                //   // itemIndex++;
                //}


                //foreach (var attr in PathModel.UniqXMLAttr)
                //{
                //    uniqAttrSheet.Cell(rowAttrib + 1, 2).Value = attr;
                //    rowAttrib++;
                //}
                #endregion

                #region Unique nodes

                IXLWorksheet uniqueAttrSheet = workbook.Worksheets.Add("Unique nodes");

                uniqueAttrSheet.SheetView.FreezeRows(1);
                uniqueAttrSheet.Columns().Style.Alignment.WrapText = false;
                IXLRow firstUAtrRow = uniqueAttrSheet.Row(1);
                firstUAtrRow.Style.Font.Bold = true;

                ////int? categ = PathModel.UniqXMLCategorys.Count;
                int rowAttr = 2;

                uniqueAttrSheet.Cell(1, 2).Value = "Unique nodes";

                foreach (var attr in PathModel.UniqXMLAttr)
                {
                    uniqueAttrSheet.Cell(rowAttr + 1, 2).Value = attr;
                    rowAttr++;
                }
                #endregion

                workbook.SaveAs(@"D:\Downloads\output_NO_RU.xlsx");            
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