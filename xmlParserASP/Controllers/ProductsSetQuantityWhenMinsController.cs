using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class ProductsSetQuantityWhenMinsController : BaseController
{
    private readonly GammaContext _context;

    public ProductsSetQuantityWhenMinsController(GammaContext context) : base(context)
    {
        _context = context;
    }

    // GET: ProductsSetQuantityWhenMins
    public async Task<IActionResult> Index()
    {
        var productNames = _context.NgProductDescriptions.Where(p => p.LanguageId == 4).Select(p => p.Name).ToListAsync();

        //var jl = _context.ProductsSetQuantityWhenMin.Join(_context.NgProducts, 
        //    psq => psq.Sku,
        //    prod => prod.Sku,
        //    (psq, prod) =>
        //    {
        //        psq, prod.ProductId
        //    })

        var result = await _context.ProductsSetQuantityWhenMin
    .Join(_context.NgProducts,
          psq => psq.Sku,                   // Порівнюємо поле Sku у таблиці ProductsSetQuantityWhenMin
          np => np.Sku,                     // Порівнюємо поле Sku у таблиці NgProduct
          (psq, np) => new { psq, np.ProductId })  // Створюємо анонімний об'єкт, що містить psq і ProductId
    .Join(_context.NgProductDescriptions,
          np2 => np2.ProductId,             // Порівнюємо поле ProductId з результату першого JOIN
          npd => npd.ProductId,             // Порівнюємо поле ProductId у таблиці NgProductDescription
          (np2, npd) => new ProductSetQtyWhenMinWithNameViewModel
          {
              ProductSetQtyWhenMinWithNameViewModel  = np2.psq,  // Зберігаємо об'єкт psq у новий об'єкт
              ProductName = npd.Name                // Зберігаємо поле Name з NgProductDescription
          })
    .ToListAsync();


        return result != null ? 
            View(await _context.ProductsSetQuantityWhenMin.ToListAsync()) :
            Problem("Entity set 'GammaContext.ProductsSetQuantityWhenMin'  is null.");
    }

    public async Task<IActionResult> ExportToExcel()
    {
        var prices = await _context.ProductsSetQuantityWhenMin.ToListAsync();
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

            Console.WriteLine($"File Name: {file.FileName}");
            Console.WriteLine($"Number of Rows: {lastRow}");

            
            for (int i = 2; i <= lastRow; i++) 
            {
                var excelRow = worksheet.Row(i);
            }
        }
        return View();
    }

    private MmProductsSetQuantityWhenMin MapExcelRowToEntity(string excelRow)
    {
        var columns = excelRow.Split(';'); // Припустимо, що дані розділені символом ";"

        if (columns.Length != 4)
        {
            return null;
        }

        bool isParsed = int.TryParse(columns[2], out int parsedMinQty);

        var entity = new MmProductsSetQuantityWhenMin
        {
            Id = int.Parse(columns[0]), 
            Sku = columns[1],
            MinQuantity = isParsed ? parsedMinQty : null,
            SetQuantity = int.Parse(columns[3]), 
        };

        return entity;
    }

   // GET: ProductsSetQuantityWhenMins/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.ProductsSetQuantityWhenMin == null)
        {
            return NotFound();
        }

        var productsSetQuantityWhenMin = await _context.ProductsSetQuantityWhenMin
            .FirstOrDefaultAsync(m => m.Id == id);
        if (productsSetQuantityWhenMin == null)
        {
            return NotFound();
        }

        return View(productsSetQuantityWhenMin);
    }

    // GET: ProductsSetQuantityWhenMins/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ProductsSetQuantityWhenMins/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Sku,MinQuantity,SetQuantity")] MmProductsSetQuantityWhenMin productsSetQuantityWhenMin)
    {
        if (ModelState.IsValid)
        {
            _context.Add(productsSetQuantityWhenMin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(productsSetQuantityWhenMin);
    }

    // GET: ProductsSetQuantityWhenMins/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.ProductsSetQuantityWhenMin == null)
        {
            return NotFound();
        }

        var productsSetQuantityWhenMin = await _context.ProductsSetQuantityWhenMin.FindAsync(id);
        if (productsSetQuantityWhenMin == null)
        {
            return NotFound();
        }
        return View(productsSetQuantityWhenMin);
    }

    // POST: ProductsSetQuantityWhenMins/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Sku,MinQuantity,SetQuantity")] MmProductsSetQuantityWhenMin productsSetQuantityWhenMin)
    {
        if (id != productsSetQuantityWhenMin.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(productsSetQuantityWhenMin);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsSetQuantityWhenMinExists(productsSetQuantityWhenMin.Id))
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
        return View(productsSetQuantityWhenMin);
    }

    // GET: ProductsSetQuantityWhenMins/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.ProductsSetQuantityWhenMin == null)
        {
            return NotFound();
        }

        var productsSetQuantityWhenMin = await _context.ProductsSetQuantityWhenMin
            .FirstOrDefaultAsync(m => m.Id == id);
        if (productsSetQuantityWhenMin == null)
        {
            return NotFound();
        }

        return View(productsSetQuantityWhenMin);
    }

    // POST: ProductsSetQuantityWhenMins/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.ProductsSetQuantityWhenMin == null)
        {
            return Problem("Entity set 'GammaContext.ProductsSetQuantityWhenMin'  is null.");
        }
        var productsSetQuantityWhenMin = await _context.ProductsSetQuantityWhenMin.FindAsync(id);
        if (productsSetQuantityWhenMin != null)
        {
            _context.ProductsSetQuantityWhenMin.Remove(productsSetQuantityWhenMin);
        }
            
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ProductsSetQuantityWhenMinExists(int id)
    {
        return (_context.ProductsSetQuantityWhenMin?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}