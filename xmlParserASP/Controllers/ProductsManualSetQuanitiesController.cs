using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class ProductsManualSetQuanitiesController : BaseController
{
    private readonly GammaContext _context;

    public ProductsManualSetQuanitiesController(GammaContext context) : base(context)
    {
        _context = context;
    }

    // GET: ProductsManualSetQuanities
    public async Task<IActionResult> Index()
    {
        var products = await _context.ProductsManualSetQuanitys.Join(
            _context.NgProductDescriptions.Where(m => m.LanguageId == 3),
            p => p.Id,
            d => d.ProductId, (p, d) => new ProductViewModel
            {
                Id = p.Id,
                Sku = p.Sku,
                SetInStockQty = p.SetInStockQty,
                DateStart = p.DateStart,
                DateEnd = p.DateEnd,
                Name = d.Name
            }).ToListAsync();

        return View(products);
    }


    public async Task<IActionResult> ExportToExcel()
    {
        var prices = await _context.ProductsManualSetQuanitys.ToListAsync();
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

    private MmProductsManualSetQuanity MapExcelRowToEntity(string excelRow)
    {
        var columns = excelRow.Split(';'); // Припустимо, що дані розділені символом ";"

        if (columns.Length != 4)
        {

            return null;
        }

        var entity = new MmProductsManualSetQuanity
        {
            Id = int.Parse(columns[0]),
            Sku = columns[1],
            SetInStockQty = int.Parse(columns[2]),
            DateStart = DateTime.Parse(columns[3]),
            DateEnd = DateTime.Parse(columns[4]),
        };

        return entity;
    }


    // GET: ProductsManualSetQuanities/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.ProductsManualSetQuanitys == null)
        {
            return NotFound();
        }

        var productsManualSetQuanity = await _context.ProductsManualSetQuanitys
            .FirstOrDefaultAsync(m => m.Id == id);
        if (productsManualSetQuanity == null)
        {
            return NotFound();
        }

        return View(productsManualSetQuanity);
    }

    // GET: ProductsManualSetQuanities/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ProductsManualSetQuanities/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Sku,SetInStockQty,DateStart,DateEnd")] MmProductsManualSetQuanity productsManualSetQuanity)
    {
        if (ModelState.IsValid)
        {
            _context.Add(productsManualSetQuanity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(productsManualSetQuanity);
    }

    // GET: ProductsManualSetQuanities/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.ProductsManualSetQuanitys == null)
        {
            return NotFound();
        }

        var productsManualSetQuanity = await _context.ProductsManualSetQuanitys.FindAsync(id);
        if (productsManualSetQuanity == null)
        {
            return NotFound();
        }
        return View(productsManualSetQuanity);
    }

    // POST: ProductsManualSetQuanities/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Sku,SetInStockQty,DateStart,DateEnd")] MmProductsManualSetQuanity productsManualSetQuanity)
    {
        if (id != productsManualSetQuanity.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(productsManualSetQuanity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsManualSetQuanityExists(productsManualSetQuanity.Id))
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
        return View(productsManualSetQuanity);
    }

    // GET: ProductsManualSetQuanities/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.ProductsManualSetQuanitys == null)
        {
            return NotFound();
        }

        var productsManualSetQuanity = await _context.ProductsManualSetQuanitys
            .FirstOrDefaultAsync(m => m.Id == id);
        if (productsManualSetQuanity == null)
        {
            return NotFound();
        }

        return View(productsManualSetQuanity);
    }

    // POST: ProductsManualSetQuanities/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.ProductsManualSetQuanitys == null)
        {
            return Problem("Entity set 'GammaContext.ProductsManualSetQuanitys'  is null.");
        }
        var productsManualSetQuanity = await _context.ProductsManualSetQuanitys.FindAsync(id);
        if (productsManualSetQuanity != null)
        {
            _context.ProductsManualSetQuanitys.Remove(productsManualSetQuanity);
        }
            
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ProductsManualSetQuanityExists(int id)
    {
        return (_context.ProductsManualSetQuanitys?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}