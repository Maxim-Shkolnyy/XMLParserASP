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
    public class AttributesController : Controller
    {
        private readonly MyDBContext _context;

        public AttributesController(MyDBContext context)
        {
            _context = context;
        }

        // GET: Attributes
        public async Task<IActionResult> Index()
        {
              return _context.MyAttributes != null ? 
                          View(await _context.MyAttributes.ToListAsync()) :
                          Problem("Entity set 'MyDBContext.MyAttributes'  is null.");
        }

        // GET: Attributes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MyAttributes == null)
            {
                return NotFound();
            }

            var myAttribute = await _context.MyAttributes
                .FirstOrDefaultAsync(m => m.MyAttrId == id);
            if (myAttribute == null)
            {
                return NotFound();
            }

            return View(myAttribute);
        }

        // GET: Attributes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Attributes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MyAttrId,MyAttrName,LanguageId")] MyAttribute myAttribute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myAttribute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myAttribute);
        }

        // GET: Attributes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MyAttributes == null)
            {
                return NotFound();
            }

            var myAttribute = await _context.MyAttributes.FindAsync(id);
            if (myAttribute == null)
            {
                return NotFound();
            }
            return View(myAttribute);
        }

        // POST: Attributes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MyAttrId,MyAttrName,LanguageId")] MyAttribute myAttribute)
        {
            if (id != myAttribute.MyAttrId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myAttribute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyAttributeExists(myAttribute.MyAttrId))
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
            return View(myAttribute);
        }

        // GET: Attributes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MyAttributes == null)
            {
                return NotFound();
            }

            var myAttribute = await _context.MyAttributes
                .FirstOrDefaultAsync(m => m.MyAttrId == id);
            if (myAttribute == null)
            {
                return NotFound();
            }

            return View(myAttribute);
        }

        // POST: Attributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MyAttributes == null)
            {
                return Problem("Entity set 'MyDBContext.MyAttributes'  is null.");
            }
            var myAttribute = await _context.MyAttributes.FindAsync(id);
            if (myAttribute != null)
            {
                _context.MyAttributes.Remove(myAttribute);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyAttributeExists(int id)
        {
          return (_context.MyAttributes?.Any(e => e.MyAttrId == id)).GetValueOrDefault();
        }
    }
}
