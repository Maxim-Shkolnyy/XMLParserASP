using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class ProductsSetQuantityWhenMinsController : Controller
{
    private readonly GammaContext _context;

    public ProductsSetQuantityWhenMinsController(GammaContext context)
    {
        _context = context;
    }

    // GET: ProductsSetQuantityWhenMins
    public async Task<IActionResult> Index()
    {
        return _context.ProductsSetQuantityWhenMin != null ? 
            View(await _context.ProductsSetQuantityWhenMin.ToListAsync()) :
            Problem("Entity set 'GammaContext.ProductsSetQuantityWhenMin'  is null.");
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