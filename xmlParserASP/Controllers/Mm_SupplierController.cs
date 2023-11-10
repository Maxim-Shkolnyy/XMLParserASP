using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers
{
    public class Mm_SupplierController : Controller
    {
        private readonly GammaContext _context;

        public Mm_SupplierController(GammaContext context)
        {
            _context = context;
        }

        // GET: Mm_Supplier
        public async Task<IActionResult> Index()
        {
              return _context.Mm_Supplier != null ? 
                          View(await _context.Mm_Supplier.ToListAsync()) :
                          Problem("Entity set 'GammaContext.Mm_Supplier'  is null.");
        }

        // GET: Mm_Supplier/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Mm_Supplier == null)
            {
                return NotFound();
            }

            var mm_Supplier = await _context.Mm_Supplier
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (mm_Supplier == null)
            {
                return NotFound();
            }

            return View(mm_Supplier);
        }

        // GET: Mm_Supplier/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mm_Supplier/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,SupplierName")] Mm_Supplier mm_Supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mm_Supplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mm_Supplier);
        }

        // GET: Mm_Supplier/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Mm_Supplier == null)
            {
                return NotFound();
            }

            var mm_Supplier = await _context.Mm_Supplier.FindAsync(id);
            if (mm_Supplier == null)
            {
                return NotFound();
            }
            return View(mm_Supplier);
        }

        // POST: Mm_Supplier/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,SupplierName")] Mm_Supplier mm_Supplier)
        {
            if (id != mm_Supplier.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mm_Supplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Mm_SupplierExists(mm_Supplier.SupplierId))
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
            return View(mm_Supplier);
        }

        // GET: Mm_Supplier/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Mm_Supplier == null)
            {
                return NotFound();
            }

            var mm_Supplier = await _context.Mm_Supplier
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (mm_Supplier == null)
            {
                return NotFound();
            }

            return View(mm_Supplier);
        }

        // POST: Mm_Supplier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Mm_Supplier == null)
            {
                return Problem("Entity set 'GammaContext.Mm_Supplier'  is null.");
            }
            var mm_Supplier = await _context.Mm_Supplier.FindAsync(id);
            if (mm_Supplier != null)
            {
                _context.Mm_Supplier.Remove(mm_Supplier);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Mm_SupplierExists(int id)
        {
          return (_context.Mm_Supplier?.Any(e => e.SupplierId == id)).GetValueOrDefault();
        }
    }
}
