using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class ProductsManualSetPricesController : BaseController
{
    private readonly GammaContext _context;

    public ProductsManualSetPricesController(GammaContext context) : base(context)
    {
        _context = context;
    }

    // GET: ProductsManualSetPrices
    public async Task<IActionResult> Index()
    {
        return _context.ProductsManualSetPrices != null ?
            View(await _context.ProductsManualSetPrices.ToListAsync()) :
            Problem("Entity set 'GammaContext.ProductsManualSetPrices'  is null.");
    }


    public async Task<IActionResult> ExportToExcel()
    {
        var prices = await _context.ProductsManualSetPrices.ToListAsync();
        return await ExportToExcel(prices.AsQueryable());
    }

    // Import action
    [HttpPost]

    public async Task<IActionResult> ImportFromExcel(IFormFile file)
    {
        // Перевіряємо, чи файл був переданий
        if (file == null || file.Length == 0)
        {
            ModelState.AddModelError("File", "Please select a file");
            return View();
        }

        using (var workbook = new XLWorkbook(file.OpenReadStream()))
        {
            var worksheet = workbook.Worksheet(1);
            var lastRow = worksheet.LastRowUsed().RowNumber();

            // Виведення інформації про файл у вікно відладки
            Console.WriteLine($"File Name: {file.FileName}");
            Console.WriteLine($"Number of Rows: {lastRow}");

            // Ітерація по кожному рядку у листі Excel
            for (int i = 2; i <= lastRow; i++) // Починаємо з 2, оскільки 1-й рядок зазвичай містить заголовки
            {
                var excelRow = worksheet.Row(i);

                // Викликаємо метод базового контролера для обробки рядка Excel
                // В якості аргументів передаємо дані рядка та функцію мапування (MapExcelRowToEntity)
                //await base.ProcessExcelRow(excelRow, MapExcelRowToEntity);
            }
        }
        return View();
    }

    private MmProductsManualSetPrice MapExcelRowToEntity(string excelRow)
    {
        var columns = excelRow.Split(';'); // Припустимо, що дані розділені символом ";"

        if (columns.Length != 5) // Перевірка, чи кількість стовпців відповідає очікуваній структурі
        {
            // Якщо кількість стовпців не відповідає очікуваній, повертаємо null, означаючи, що рядок не може бути коректно мапований
            return null;
        }

        // Створюємо новий об'єкт сутності і заповнюємо його поля з даних рядка
        var entity = new MmProductsManualSetPrice
        {
            Id = int.Parse(columns[0]), // Перший стовпець мапуємо на Id
            Sku = columns[1], // Другий стовпець мапуємо на Sku
            SetInStockPrice = decimal.Parse(columns[2]), // Третій стовпець мапуємо на SetInStockPrice
            DateStart = DateTime.Parse(columns[3]), // Четвертий стовпець мапуємо на DateStart
            DateEnd = string.IsNullOrEmpty(columns[4]) ? (DateTime?)null : DateTime.Parse(columns[4]) // П'ятий стовпець мапуємо на DateEnd, з урахуванням можливого значення null
        };

        return entity;
    }


   // GET: ProductsManualSetPrices/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.ProductsManualSetPrices == null)
        {
            return NotFound();
        }

        var productsManualSetPrice = await _context.ProductsManualSetPrices
            .FirstOrDefaultAsync(m => m.Id == id);
        if (productsManualSetPrice == null)
        {
            return NotFound();
        }

        return View(productsManualSetPrice);
    }

    // GET: ProductsManualSetPrices/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ProductsManualSetPrices/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Sku,SetInStockPrice,DateStart,DateEnd")] MmProductsManualSetPrice productsManualSetPrice)
    {
        if (ModelState.IsValid)
        {
            _context.Add(productsManualSetPrice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(productsManualSetPrice);
    }

    // GET: ProductsManualSetPrices/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.ProductsManualSetPrices == null)
        {
            return NotFound();
        }

        var productsManualSetPrice = await _context.ProductsManualSetPrices.FindAsync(id);
        if (productsManualSetPrice == null)
        {
            return NotFound();
        }
        return View(productsManualSetPrice);
    }

    // POST: ProductsManualSetPrices/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Sku,SetInStockPrice,DateStart,DateEnd")] MmProductsManualSetPrice productsManualSetPrice)
    {
        if (id != productsManualSetPrice.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(productsManualSetPrice);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsManualSetPriceExists(productsManualSetPrice.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(productsManualSetPrice);
    }

    // GET: ProductsManualSetPrices/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.ProductsManualSetPrices == null)
        {
            return NotFound();
        }

        var productsManualSetPrice = await _context.ProductsManualSetPrices
            .FirstOrDefaultAsync(m => m.Id == id);
        if (productsManualSetPrice == null)
        {
            return NotFound();
        }

        return View(productsManualSetPrice);
    }

    // POST: ProductsManualSetPrices/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.ProductsManualSetPrices == null)
        {
            return Problem("Entity set 'GammaContext.ProductsManualSetPrices'  is null.");
        }
        var productsManualSetPrice = await _context.ProductsManualSetPrices.FindAsync(id);
        if (productsManualSetPrice != null)
        {
            _context.ProductsManualSetPrices.Remove(productsManualSetPrice);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ProductsManualSetPriceExists(int id)
    {
        return (_context.ProductsManualSetPrices?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}