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
    public class SupplierXmlSettingsController : Controller
    {
        private readonly MyDBContext _context;

        public SupplierXmlSettingsController(MyDBContext context)
        {
            _context = context;
        }

        // GET: SupplierXmlSettings
        public async Task<IActionResult> Index()
        {
            var myDBContext = _context.SupplierXmlSettings.Include(s => s.Supplier);
            return View(await myDBContext.ToListAsync());
        }

        // GET: SupplierXmlSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SupplierXmlSettings == null)
            {
                return NotFound();
            }

            var supplierXmlSetting = await _context.SupplierXmlSettings
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingId == id);
            if (supplierXmlSetting == null)
            {
                return NotFound();
            }

            return View(supplierXmlSetting);
        }

        // GET: SupplierXmlSettings/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName");
            return View();
        }

        // POST: SupplierXmlSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierXmlSettingId,SettingName,SupplierId,Path,StartGammaIDFrom,ProductNode,paramAttribute,ModelNode,ModelXlColumn,PriceNode,DescriptionNode,NameNode,CurrencyNode,PictureNode,PicturePriceQuantityXlColumn,imageNameInCatImg,PhotoFolder,QuantityNode,QuantityLongTermNode,SupplierNode,ParamNode,ParamAttrNode")] SupplierXmlSetting supplierXmlSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierXmlSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", supplierXmlSetting.SupplierId);
            return View(supplierXmlSetting);
        }

        // GET: SupplierXmlSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SupplierXmlSettings == null)
            {
                return NotFound();
            }

            var supplierXmlSetting = await _context.SupplierXmlSettings.FindAsync(id);
            if (supplierXmlSetting == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", supplierXmlSetting.SupplierId);
            return View(supplierXmlSetting);
        }

        // POST: SupplierXmlSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierXmlSettingId,SettingName,SupplierId,Path,StartGammaIDFrom,ProductNode,paramAttribute,ModelNode,ModelXlColumn,PriceNode,DescriptionNode,NameNode,CurrencyNode,PictureNode,PicturePriceQuantityXlColumn,imageNameInCatImg,PhotoFolder,QuantityNode,QuantityLongTermNode,SupplierNode,ParamNode,ParamAttrNode")] SupplierXmlSetting supplierXmlSetting)
        {
            if (id != supplierXmlSetting.SupplierXmlSettingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierXmlSetting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierXmlSettingExists(supplierXmlSetting.SupplierXmlSettingId))
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
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", supplierXmlSetting.SupplierId);
            return View(supplierXmlSetting);
        }

        // GET: SupplierXmlSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SupplierXmlSettings == null)
            {
                return NotFound();
            }

            var supplierXmlSetting = await _context.SupplierXmlSettings
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingId == id);
            if (supplierXmlSetting == null)
            {
                return NotFound();
            }

            return View(supplierXmlSetting);
        }

        // POST: SupplierXmlSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SupplierXmlSettings == null)
            {
                return Problem("Entity set 'MyDBContext.SupplierXmlSettings'  is null.");
            }
            var supplierXmlSetting = await _context.SupplierXmlSettings.FindAsync(id);
            if (supplierXmlSetting != null)
            {
                _context.SupplierXmlSettings.Remove(supplierXmlSetting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierXmlSettingExists(int id)
        {
          return (_context.SupplierXmlSettings?.Any(e => e.SupplierXmlSettingId == id)).GetValueOrDefault();
        }
    }
}
