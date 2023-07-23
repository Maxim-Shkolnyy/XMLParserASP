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
              return _context.SupplierXmlSettings != null ? 
                          View(await _context.SupplierXmlSettings.ToListAsync()) :
                          Problem("Entity set 'MyDBContext.SupplierXmlSettings'  is null.");
        }

        // GET: SupplierXmlSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SupplierXmlSettings == null)
            {
                return NotFound();
            }

            var supplierXmlSetting = await _context.SupplierXmlSettings
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingID == id);
            if (supplierXmlSetting == null)
            {
                return NotFound();
            }

            return View(supplierXmlSetting);
        }

        // GET: SupplierXmlSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupplierXmlSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierXmlSettingID,SupplierXmlSettingName,SupplierId,StartGammaIDFrom,ProductNode,ModelNode,PictureNode,imageNameInCatImg,PhotoFolder,QuantityNode,SupplierNode,ParamNode,ParamAttrNode")] SupplierXmlSetting supplierXmlSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierXmlSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
            return View(supplierXmlSetting);
        }

        // POST: SupplierXmlSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierXmlSettingID,SupplierXmlSettingName,SupplierId,StartGammaIDFrom,ProductNode,ModelNode,PictureNode,imageNameInCatImg,PhotoFolder,QuantityNode,SupplierNode,ParamNode,ParamAttrNode")] SupplierXmlSetting supplierXmlSetting)
        {
            if (id != supplierXmlSetting.SupplierXmlSettingID)
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
                    if (!SupplierXmlSettingExists(supplierXmlSetting.SupplierXmlSettingID))
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
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingID == id);
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
          return (_context.SupplierXmlSettings?.Any(e => e.SupplierXmlSettingID == id)).GetValueOrDefault();
        }
    }
}
