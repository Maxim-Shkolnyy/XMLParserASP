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
    public class MmSuppliersController : Controller
    {
        private readonly GammaContext _context;

        public MmSuppliersController(GammaContext context)
        {
            _context = context;
        }

        // GET: MmSuppliers
        public async Task<IActionResult> Index()
        {
              return _context.MmSuppliers != null ? 
                          View(await _context.MmSuppliers.ToListAsync()) :
                          Problem("Entity set 'GammaContext.MmSuppliers'  is null.");
        }

        // GET: MmSuppliers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MmSuppliers == null)
            {
                return NotFound();
            }

            var mmSupplier = await _context.MmSuppliers
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (mmSupplier == null)
            {
                return NotFound();
            }

            return View(mmSupplier);
        }

        // GET: MmSuppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MmSuppliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,SupplierName")] MmSupplier mmSupplier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mmSupplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mmSupplier);
        }

        // GET: MmSuppliers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MmSuppliers == null)
            {
                return NotFound();
            }

            var mmSupplier = await _context.MmSuppliers.FindAsync(id);
            if (mmSupplier == null)
            {
                return NotFound();
            }
            return View(mmSupplier);
        }

        // POST: MmSuppliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,SupplierName")] MmSupplier mmSupplier)
        {
            if (id != mmSupplier.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mmSupplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MmSupplierExists(mmSupplier.SupplierId))
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
            return View(mmSupplier);
        }

        // GET: MmSuppliers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MmSuppliers == null)
            {
                return NotFound();
            }

            var mmSupplier = await _context.MmSuppliers
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (mmSupplier == null)
            {
                return NotFound();
            }

            return View(mmSupplier);
        }

        // POST: MmSuppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MmSuppliers == null)
            {
                return Problem("Entity set 'GammaContext.MmSuppliers'  is null.");
            }
            var mmSupplier = await _context.MmSuppliers.FindAsync(id);
            if (mmSupplier != null)
            {
                _context.MmSuppliers.Remove(mmSupplier);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MmSupplierExists(int id)
        {
          return (_context.MmSuppliers?.Any(e => e.SupplierId == id)).GetValueOrDefault();
        }
    }
}
