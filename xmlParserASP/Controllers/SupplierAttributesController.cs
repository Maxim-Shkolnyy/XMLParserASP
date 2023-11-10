using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.TestGamma.OldMy;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class SupplierAttributesController : Controller
{
    private readonly MyDBContext _context;

    public SupplierAttributesController(MyDBContext context)
    {
        _context = context;
    }

    // GET: SupplierAttributes
    public async Task<IActionResult> Index()
    {
          return _context.SupplierAttributes != null ? 
                      View(await _context.SupplierAttributes.ToListAsync()) :
                      Problem("Entity set 'MyDBContext.SupplierAttributes'  is null.");
    }

    // GET: SupplierAttributes/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.SupplierAttributes == null)
        {
            return NotFound();
        }

        var supplierAttribute = await _context.SupplierAttributes
            .FirstOrDefaultAsync(m => m.SupAttrId == id);
        if (supplierAttribute == null)
        {
            return NotFound();
        }

        return View(supplierAttribute);
    }

    // GET: SupplierAttributes/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: SupplierAttributes/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("SupAttrId,SupplierId,SupAttrNameRU,LanguageId")] SupplierAttribute supplierAttribute)
    {
        if (ModelState.IsValid)
        {
            _context.Add(supplierAttribute);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(supplierAttribute);
    }

    // GET: SupplierAttributes/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.SupplierAttributes == null)
        {
            return NotFound();
        }

        var supplierAttribute = await _context.SupplierAttributes.FindAsync(id);
        if (supplierAttribute == null)
        {
            return NotFound();
        }
        return View(supplierAttribute);
    }

    // POST: SupplierAttributes/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("SupAttrId,SupplierId,SupAttrNameRU,LanguageId")] SupplierAttribute supplierAttribute)
    {
        if (id != supplierAttribute.SupAttrId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(supplierAttribute);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierAttributeExists(supplierAttribute.SupAttrId))
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
        return View(supplierAttribute);
    }

    // GET: SupplierAttributes/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.SupplierAttributes == null)
        {
            return NotFound();
        }

        var supplierAttribute = await _context.SupplierAttributes
            .FirstOrDefaultAsync(m => m.SupAttrId == id);
        if (supplierAttribute == null)
        {
            return NotFound();
        }

        return View(supplierAttribute);
    }

    // POST: SupplierAttributes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.SupplierAttributes == null)
        {
            return Problem("Entity set 'MyDBContext.SupplierAttributes'  is null.");
        }
        var supplierAttribute = await _context.SupplierAttributes.FindAsync(id);
        if (supplierAttribute != null)
        {
            _context.SupplierAttributes.Remove(supplierAttribute);
        }
        
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool SupplierAttributeExists(int id)
    {
      return (_context.SupplierAttributes?.Any(e => e.SupAttrId == id)).GetValueOrDefault();
    }
}
