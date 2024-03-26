using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class BaseController : Controller
{
    private readonly GammaContext _context;
    public BaseController(GammaContext context)
    {
        _context = context;
    }
    protected async Task<IActionResult> ExportToExcel<T>(IQueryable<T> data)
    {
        var modelName = typeof(T).Name;
        var time = DateTime.Now;

        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Max");
            var currentRow = 1;

            var properties = typeof(T).GetProperties();

            var headerRow = worksheet.Row(currentRow);

            worksheet.Row(1).Style.Font.Bold = true;
            worksheet.SheetView.FreezeRows(1);
            worksheet.Row(2).Style.Fill.BackgroundColor = XLColor.Yellow;

            for (int i = 0; i < properties.Length; i++)
            {
                headerRow.Cell(i + 1).Value = properties[i].Name;
            }
            currentRow++;

            foreach (var item in data)
            {
                for (int i = 0; i < properties.Length; i++)
                {
                    var value = properties[i].GetValue(item);
                    worksheet.Cell(currentRow, i + 1).Value = value?.ToString();
                }
                currentRow++;
            }

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);

                var content = stream.ToArray();

                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{modelName}_{time}.xlsx");
            }
        }
    }


    protected async Task<IActionResult> ImportFromExcel<T>(Stream stream, Func<string, T> mapper) where T : class
    {
        var entityType = typeof(T);

        using (var workbook = new XLWorkbook(stream))
        {
            var worksheet = workbook.Worksheet(1);
            var rowCount = worksheet.RowsUsed().Count();

            for (int i = 2; i <= rowCount; i++)
            {
                var entity = mapper(worksheet.Cell(i, 1).Value.ToString());
                if (entity != null)
                {
                    var keyPropertyValue = worksheet.Cell(i, 1).Value.ToString(); // Assuming the first cell contains the key property value
                    var existingEntity = await _context.FindAsync<T>(keyPropertyValue);


                    // Find the existing entity by its key property value

                    if (existingEntity != null)
                    {
                        var properties = entityType.GetProperties();
                        for (int j = 0; j < properties.Length; j++)
                        {
                            var value = worksheet.Cell(i, j + 1).Value.ToString();
                            var property = properties[j];
                            // Convert value to the appropriate type if necessary
                            if (property.PropertyType.IsEnum)
                            {
                                property.SetValue(existingEntity, Enum.Parse(property.PropertyType, value));
                            }
                            else
                            {
                                property.SetValue(existingEntity, Convert.ChangeType(value, property.PropertyType));
                            }
                        }
                    }
                }
            }
            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Index");
    }

}