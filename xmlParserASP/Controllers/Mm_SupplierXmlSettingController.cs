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
    public class Mm_SupplierXmlSettingController : Controller
    {
        private readonly GammaContext _context;

        public Mm_SupplierXmlSettingController(GammaContext context)
        {
            _context = context;
        }

        // GET: Mm_SupplierXmlSetting
        public async Task<IActionResult> Index()
        {
            var gammaContext = _context.Mm_SupplierXmlSettings.Include(m => m.Supplier);
            return View(await gammaContext.ToListAsync());
        }

        // GET: Mm_SupplierXmlSetting/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Mm_SupplierXmlSettings == null)
            {
                return NotFound();
            }

            var mm_SupplierXmlSetting = await _context.Mm_SupplierXmlSettings
                .Include(m => m.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingId == id);
            if (mm_SupplierXmlSetting == null)
            {
                return NotFound();
            }

            return View(mm_SupplierXmlSetting);
        }

        // GET: Mm_SupplierXmlSetting/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Mm_Supplier, "SupplierId", "SupplierName");
            return View();
        }

        // POST: Mm_SupplierXmlSetting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierXmlSettingId,SettingName,SupplierId,Path,MainProductNode,ProductNode,paramAttribute,ModelNode,ModelXlColumn,PicturePriceQuantityXlColumn,QtyInBoxColumnNumber,PhotoFolder,PriceNode,DescriptionNode,NameNode,CurrencyNode,PictureNode,QuantityNode,QuantityDBStock1,QuantityDBStock2,QuantityDBStock3,QuantityDBStock4,QuantityDBStock5,QuantityLongTermNode,SupplierNode,ParamNode,ParamAttrNode")] Mm_SupplierXmlSetting mm_SupplierXmlSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mm_SupplierXmlSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierId"] = new SelectList(_context.Mm_Supplier, "SupplierId", "SupplierName", mm_SupplierXmlSetting.SupplierId);
            return View(mm_SupplierXmlSetting);
        }

        // GET: Mm_SupplierXmlSetting/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Mm_SupplierXmlSettings == null)
            {
                return NotFound();
            }

            var mm_SupplierXmlSetting = await _context.Mm_SupplierXmlSettings.FindAsync(id);
            if (mm_SupplierXmlSetting == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Mm_Supplier, "SupplierId", "SupplierName", mm_SupplierXmlSetting.SupplierId);
            return View(mm_SupplierXmlSetting);
        }

        // POST: Mm_SupplierXmlSetting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierXmlSettingId,SettingName,SupplierId,Path,MainProductNode,ProductNode,paramAttribute,ModelNode,ModelXlColumn,PicturePriceQuantityXlColumn,QtyInBoxColumnNumber,PhotoFolder,PriceNode,DescriptionNode,NameNode,CurrencyNode,PictureNode,QuantityNode,QuantityDBStock1,QuantityDBStock2,QuantityDBStock3,QuantityDBStock4,QuantityDBStock5,QuantityLongTermNode,SupplierNode,ParamNode,ParamAttrNode")] Mm_SupplierXmlSetting mm_SupplierXmlSetting)
        {
            if (id != mm_SupplierXmlSetting.SupplierXmlSettingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mm_SupplierXmlSetting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Mm_SupplierXmlSettingExists(mm_SupplierXmlSetting.SupplierXmlSettingId))
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
            ViewData["SupplierId"] = new SelectList(_context.Mm_Supplier, "SupplierId", "SupplierName", mm_SupplierXmlSetting.SupplierId);
            return View(mm_SupplierXmlSetting);
        }

        // GET: Mm_SupplierXmlSetting/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Mm_SupplierXmlSettings == null)
            {
                return NotFound();
            }

            var mm_SupplierXmlSetting = await _context.Mm_SupplierXmlSettings
                .Include(m => m.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingId == id);
            if (mm_SupplierXmlSetting == null)
            {
                return NotFound();
            }

            return View(mm_SupplierXmlSetting);
        }

        // POST: Mm_SupplierXmlSetting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Mm_SupplierXmlSettings == null)
            {
                return Problem("Entity set 'GammaContext.Mm_SupplierXmlSettings'  is null.");
            }
            var mm_SupplierXmlSetting = await _context.Mm_SupplierXmlSettings.FindAsync(id);
            if (mm_SupplierXmlSetting != null)
            {
                _context.Mm_SupplierXmlSettings.Remove(mm_SupplierXmlSetting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Mm_SupplierXmlSettingExists(int id)
        {
          return (_context.Mm_SupplierXmlSettings?.Any(e => e.SupplierXmlSettingId == id)).GetValueOrDefault();
        }
    }
}
