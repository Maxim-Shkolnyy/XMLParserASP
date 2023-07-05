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
    public class MyCategoriesController : Controller
    {
        private readonly MyDBContext _context;

        public MyCategoriesController(MyDBContext context)
        {
            _context = context;
        }

        // GET: MyCategories
        public async Task<IActionResult> Index()
        {
              return _context.MyCategories != null ? 
                          View(await _context.MyCategories.ToListAsync()) :
                          Problem("Entity set 'MyDBContext.MyCategories'  is null.");
        }

        // GET: MyCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MyCategories == null)
            {
                return NotFound();
            }

            var myCategory = await _context.MyCategories
                .FirstOrDefaultAsync(m => m.MyCatId == id);
            if (myCategory == null)
            {
                return NotFound();
            }

            return View(myCategory);
        }

        // GET: MyCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MyCatId,MyParentCatId,MyCatName,LanguageId")] MyCategory myCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myCategory);
        }

        // GET: MyCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MyCategories == null)
            {
                return NotFound();
            }

            var myCategory = await _context.MyCategories.FindAsync(id);
            if (myCategory == null)
            {
                return NotFound();
            }
            return View(myCategory);
        }

        // POST: MyCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MyCatId,MyParentCatId,MyCatName,LanguageId")] MyCategory myCategory)
        {
            if (id != myCategory.MyCatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyCategoryExists(myCategory.MyCatId))
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
            return View(myCategory);
        }

        // GET: MyCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MyCategories == null)
            {
                return NotFound();
            }

            var myCategory = await _context.MyCategories
                .FirstOrDefaultAsync(m => m.MyCatId == id);
            if (myCategory == null)
            {
                return NotFound();
            }

            return View(myCategory);
        }

        // POST: MyCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MyCategories == null)
            {
                return Problem("Entity set 'MyDBContext.MyCategories'  is null.");
            }
            var myCategory = await _context.MyCategories.FindAsync(id);
            if (myCategory != null)
            {
                _context.MyCategories.Remove(myCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyCategoryExists(int id)
        {
          return (_context.MyCategories?.Any(e => e.MyCatId == id)).GetValueOrDefault();
        }
    }
}
