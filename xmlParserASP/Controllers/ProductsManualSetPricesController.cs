using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers
{
    public class ProductsManualSetPricesController : Controller
    {
        private readonly GammaContext _context;

        public ProductsManualSetPricesController(GammaContext context)
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
        public async Task<IActionResult> Create([Bind("Id,Sku,SetInStockPrice,DateStart,DateEnd")] ProductsManualSetPrice productsManualSetPrice)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sku,SetInStockPrice,DateStart,DateEnd")] ProductsManualSetPrice productsManualSetPrice)
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
}
