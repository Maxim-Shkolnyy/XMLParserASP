using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers
{
    public class SupplierCategoriesController : Controller
    {
        private readonly MyDBContext _context;

        public SupplierCategoriesController(MyDBContext context)
        {
            _context = context;
        }

        // GET: SupplierCategories
        public async Task<IActionResult> Index()
        {
              return _context.SupplierCategories != null ? 
                          View(await _context.SupplierCategories.ToListAsync()) :
                          Problem("Entity set 'MyDBContext.SupplierCategories'  is null.");
        }

        // GET: SupplierCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SupplierCategories == null)
            {
                return NotFound();
            }

            var supplierCategory = await _context.SupplierCategories
                .FirstOrDefaultAsync(m => m.SupplierCatId == id);
            if (supplierCategory == null)
            {
                return NotFound();
            }

            return View(supplierCategory);
        }

        // GET: SupplierCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupplierCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierCatId,SupplierId,ParentSupCatId,CatNameRU,LanguageId")] SupplierCategory supplierCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplierCategory);
        }

        // GET: SupplierCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SupplierCategories == null)
            {
                return NotFound();
            }

            var supplierCategory = await _context.SupplierCategories.FindAsync(id);
            if (supplierCategory == null)
            {
                return NotFound();
            }
            return View(supplierCategory);
        }

        // POST: SupplierCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierCatId,SupplierId,ParentSupCatId,CatNameRU,LanguageId")] SupplierCategory supplierCategory)
        {
            if (id != supplierCategory.SupplierCatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierCategoryExists(supplierCategory.SupplierCatId))
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
            return View(supplierCategory);
        }

        // GET: SupplierCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SupplierCategories == null)
            {
                return NotFound();
            }

            var supplierCategory = await _context.SupplierCategories
                .FirstOrDefaultAsync(m => m.SupplierCatId == id);
            if (supplierCategory == null)
            {
                return NotFound();
            }

            return View(supplierCategory);
        }

        // POST: SupplierCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SupplierCategories == null)
            {
                return Problem("Entity set 'MyDBContext.SupplierCategories'  is null.");
            }
            var supplierCategory = await _context.SupplierCategories.FindAsync(id);
            if (supplierCategory != null)
            {
                _context.SupplierCategories.Remove(supplierCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierCategoryExists(int id)
        {
          return (_context.SupplierCategories?.Any(e => e.SupplierCatId == id)).GetValueOrDefault();
        }
    }
}
