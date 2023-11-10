using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class SuppliersController : Controller
{
    private readonly GammaContext _context;

    public SuppliersController(GammaContext context)
    {
        _context = context;
    }

    // GET: Suppliers
    public async Task<IActionResult> Index()
    {
          return _context.Mm_Supplier != null ? 
                      View(await _context.Mm_Supplier.OrderBy(n => n.SupplierName).ToListAsync()) :
                      Problem("Entity set 'MyDBContext.Suppliers'  is null.");
    }

    // GET: Suppliers/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Mm_Supplier == null)
        {
            return NotFound();
        }

        var supplier = await _context.Mm_Supplier
            .FirstOrDefaultAsync(m => m.SupplierId == id);
        if (supplier == null)
        {
            return NotFound();
        }

        return View(supplier);
    }

    // GET: Suppliers/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Suppliers/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    //[ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("SupplierName")] Mm_Supplier supplier)
    {
        if (ModelState.IsValid)
        {
            _context.Add(supplier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(supplier);
    }

    // GET: Suppliers/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.Mm_Supplier == null)
        {
            return NotFound();
        }

        var supplier = await _context.Mm_Supplier.FindAsync(id);
        if (supplier == null)
        {
            return NotFound();
        }
        return View(supplier);
    }

    // POST: Suppliers/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("SupplierId,SupplierName")] Mm_Supplier supplier)
    {
        if (id != supplier.SupplierId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(supplier);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(supplier.SupplierId))
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
        return View(supplier);
    }

    // GET: Suppliers/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.Mm_Supplier == null)
        {
            return NotFound();
        }

        var supplier = await _context.Mm_Supplier
            .FirstOrDefaultAsync(m => m.SupplierId.Equals(id));
        if (supplier == null)
        {
            return NotFound();
        }

        return View(supplier);
    }

    // POST: Suppliers/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.Mm_Supplier == null)
        {
            return Problem("Entity set 'MyDBContext.Suppliers'  is null.");
        }
        var supplier = await _context.Mm_Supplier.FindAsync(id);
        if (supplier != null)
        {
            _context.Mm_Supplier.Remove(supplier);
        }
        
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool SupplierExists(int supplier)
    {
      return (_context.Mm_Supplier?.Any(e => e.SupplierId.Equals(supplier))).GetValueOrDefault();
    }
}
