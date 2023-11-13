using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers
{
    public class Mm_ManualSetPriceController : Controller
    {
        private readonly GammaContext _context;

        public Mm_ManualSetPriceController(GammaContext context)
        {
            _context = context;
        }

        // GET: Mm_ManualSetPrice
        public async Task<IActionResult> Index()
        {
              return _context.ProductsManualSetPrices != null ? 
                          View(await _context.ProductsManualSetPrices.ToListAsync()) :
                          Problem("Entity set 'GammaContext.ProductsManualSetPrices'  is null.");
        }

        // GET: Mm_ManualSetPrice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductsManualSetPrices == null)
            {
                return NotFound();
            }

            var mm_ManualSetPrice = await _context.ProductsManualSetPrices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mm_ManualSetPrice == null)
            {
                return NotFound();
            }

            return View(mm_ManualSetPrice);
        }

        // GET: Mm_ManualSetPrice/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mm_ManualSetPrice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sku,SetInStockPrice,DateStart,DateEnd")] Mm_ManualSetPrice mm_ManualSetPrice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mm_ManualSetPrice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mm_ManualSetPrice);
        }

        // GET: Mm_ManualSetPrice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductsManualSetPrices == null)
            {
                return NotFound();
            }

            var mm_ManualSetPrice = await _context.ProductsManualSetPrices.FindAsync(id);
            if (mm_ManualSetPrice == null)
            {
                return NotFound();
            }
            return View(mm_ManualSetPrice);
        }

        // POST: Mm_ManualSetPrice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sku,SetInStockPrice,DateStart,DateEnd")] Mm_ManualSetPrice mm_ManualSetPrice)
        {
            if (id != mm_ManualSetPrice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mm_ManualSetPrice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Mm_ManualSetPriceExists(mm_ManualSetPrice.Id))
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
            return View(mm_ManualSetPrice);
        }

        // GET: Mm_ManualSetPrice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductsManualSetPrices == null)
            {
                return NotFound();
            }

            var mm_ManualSetPrice = await _context.ProductsManualSetPrices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mm_ManualSetPrice == null)
            {
                return NotFound();
            }

            return View(mm_ManualSetPrice);
        }

        // POST: Mm_ManualSetPrice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductsManualSetPrices == null)
            {
                return Problem("Entity set 'GammaContext.ProductsManualSetPrices'  is null.");
            }
            var mm_ManualSetPrice = await _context.ProductsManualSetPrices.FindAsync(id);
            if (mm_ManualSetPrice != null)
            {
                _context.ProductsManualSetPrices.Remove(mm_ManualSetPrice);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Mm_ManualSetPriceExists(int id)
        {
          return (_context.ProductsManualSetPrices?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
