using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        // GET: OcProducts
        public async Task<IActionResult> Index()
        {
              return _context.OcProducts != null ? 
                          View(await _context.OcProducts.Take(20).ToListAsync()) :
                          Problem("Entity set 'GammaContext.OcProducts'  is null.");
        }

        // GET: OcProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OcProducts == null)
            {
                return NotFound();
            }

            var ocProduct = await _context.OcProducts
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (ocProduct == null)
            {
                return NotFound();
            }

            return View(ocProduct);
        }

        // GET: OcProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OcProducts/Create
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

        // GET: OcProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OcProducts == null)
            {
                return NotFound();
            }

            var ocProduct = await _context.OcProducts.FindAsync(id);
            if (ocProduct == null)
            {
                return NotFound();
            }
            return View(ocProduct);
        }

        // POST: OcProducts/Edit/5
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

        // GET: OcProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OcProducts == null)
            {
                return NotFound();
            }

            var ocProduct = await _context.OcProducts
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (ocProduct == null)
            {
                return NotFound();
            }

            return View(ocProduct);
        }

        // POST: OcProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OcProducts == null)
            {
                return Problem("Entity set 'GammaContext.OcProducts'  is null.");
            }
            var ocProduct = await _context.OcProducts.FindAsync(id);
            if (ocProduct != null)
            {
                _context.OcProducts.Remove(ocProduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcProductExists(int id)
        {
          return (_context.OcProducts?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
