using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers
{
    public class OcProductsController : Controller
    {
        private readonly GammaContext _context;

        public OcProductsController(GammaContext context)
        {
            _context = context;
        }

        // GET: NgProducts
        public async Task<IActionResult> Index()
        {
              return _context.NgProducts != null ? 
                          View(await _context.NgProducts.Take(20).OrderByDescending(p => p.Sku).ToListAsync()) :
                          Problem("Entity set 'GammaContext.NgProducts'  is null.");
        }

        // GET: NgProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NgProducts == null)
            {
                return NotFound();
            }

            var ocProduct = await _context.NgProducts
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (ocProduct == null)
            {
                return NotFound();
            }

            return View(ocProduct);
        }

        // GET: NgProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NgProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,NixSupplierId,NixSupplierProductId,Model,Sku,Upc,Ean,Jan,Isbn,Mpn,Location,Quantity,StockStatusId,Image,ManufacturerId,Shipping,Price,Points,TaxClassId,DateAvailable,UnitId,Weight,WeightClassId,Length,Width,Height,LengthClassId,Subtract,Minimum,SortOrder,Status,Viewed,DateAdded,DateModified,Cost,SupplerCode,SupplerType")] OcProduct ocProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ocProduct);
        }

        // GET: NgProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NgProducts == null)
            {
                return NotFound();
            }

            var ocProduct = await _context.NgProducts.FindAsync(id);
            if (ocProduct == null)
            {
                return NotFound();
            }
            return View(ocProduct);
        }

        // POST: NgProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,NixSupplierId,NixSupplierProductId,Model,Sku,Upc,Ean,Jan,Isbn,Mpn,Location,Quantity,StockStatusId,Image,ManufacturerId,Shipping,Price,Points,TaxClassId,DateAvailable,UnitId,Weight,WeightClassId,Length,Width,Height,LengthClassId,Subtract,Minimum,SortOrder,Status,Viewed,DateAdded,DateModified,Cost,SupplerCode,SupplerType")] OcProduct ocProduct)
        {
            if (id != ocProduct.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ocProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcProductExists(ocProduct.ProductId))
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
            return View(ocProduct);
        }

        // GET: NgProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NgProducts == null)
            {
                return NotFound();
            }

            var ocProduct = await _context.NgProducts
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (ocProduct == null)
            {
                return NotFound();
            }

            return View(ocProduct);
        }

        // POST: NgProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NgProducts == null)
            {
                return Problem("Entity set 'GammaContext.NgProducts'  is null.");
            }
            var ocProduct = await _context.NgProducts.FindAsync(id);
            if (ocProduct != null)
            {
                _context.NgProducts.Remove(ocProduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcProductExists(int id)
        {
          return (_context.NgProducts?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
