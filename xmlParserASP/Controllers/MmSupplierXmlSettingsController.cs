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
    public class MmSupplierXmlSettingsController : Controller
    {
        private readonly GammaContext _context;

        public MmSupplierXmlSettingsController(GammaContext context)
        {
            _context = context;
        }

        // GET: MmSupplierXmlSettings
        public async Task<IActionResult> Index()
        {
              return _context.MmSupplierXmlSettings != null ? 
                          View(await _context.MmSupplierXmlSettings.ToListAsync()) :
                          Problem("Entity set 'GammaContext.MmSupplierXmlSettings'  is null.");
        }

        // GET: MmSupplierXmlSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MmSupplierXmlSettings == null)
            {
                return NotFound();
            }

            var mmSupplierXmlSetting = await _context.MmSupplierXmlSettings
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingId == id);
            if (mmSupplierXmlSetting == null)
            {
                return NotFound();
            }

            return View(mmSupplierXmlSetting);
        }

        // GET: MmSupplierXmlSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MmSupplierXmlSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierXmlSettingId,SettingName,SupplierId,Path,MainProductNode,ProductNode,ParamAttribute,ModelNode,ModelXlColumn,PriceNode,DescriptionNode,NameNode,CurrencyNode,PictureNode,PicturePriceQuantityXlColumn,PhotoFolder,QuantityNode,QuantityDbStock1,QuantityDbStock2,QuantityDbStock3,QuantityDbStock4,QuantityDbStock5,QuantityLongTermNode,SupplierNode,ParamNode,ParamAttrNode,QtyInBoxColumnNumber")] MmSupplierXmlSetting mmSupplierXmlSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mmSupplierXmlSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mmSupplierXmlSetting);
        }

        // GET: MmSupplierXmlSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MmSupplierXmlSettings == null)
            {
                return NotFound();
            }

            var mmSupplierXmlSetting = await _context.MmSupplierXmlSettings.FindAsync(id);
            if (mmSupplierXmlSetting == null)
            {
                return NotFound();
            }
            return View(mmSupplierXmlSetting);
        }

        // POST: MmSupplierXmlSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierXmlSettingId,SettingName,SupplierId,Path,MainProductNode,ProductNode,ParamAttribute,ModelNode,ModelXlColumn,PriceNode,DescriptionNode,NameNode,CurrencyNode,PictureNode,PicturePriceQuantityXlColumn,PhotoFolder,QuantityNode,QuantityDbStock1,QuantityDbStock2,QuantityDbStock3,QuantityDbStock4,QuantityDbStock5,QuantityLongTermNode,SupplierNode,ParamNode,ParamAttrNode,QtyInBoxColumnNumber")] MmSupplierXmlSetting mmSupplierXmlSetting)
        {
            if (id != mmSupplierXmlSetting.SupplierXmlSettingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mmSupplierXmlSetting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MmSupplierXmlSettingExists(mmSupplierXmlSetting.SupplierXmlSettingId))
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
            return View(mmSupplierXmlSetting);
        }

        // GET: MmSupplierXmlSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MmSupplierXmlSettings == null)
            {
                return NotFound();
            }

            var mmSupplierXmlSetting = await _context.MmSupplierXmlSettings
                .FirstOrDefaultAsync(m => m.SupplierXmlSettingId == id);
            if (mmSupplierXmlSetting == null)
            {
                return NotFound();
            }

            return View(mmSupplierXmlSetting);
        }

        // POST: MmSupplierXmlSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MmSupplierXmlSettings == null)
            {
                return Problem("Entity set 'GammaContext.MmSupplierXmlSettings'  is null.");
            }
            var mmSupplierXmlSetting = await _context.MmSupplierXmlSettings.FindAsync(id);
            if (mmSupplierXmlSetting != null)
            {
                _context.MmSupplierXmlSettings.Remove(mmSupplierXmlSetting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MmSupplierXmlSettingExists(int id)
        {
          return (_context.MmSupplierXmlSettings?.Any(e => e.SupplierXmlSettingId == id)).GetValueOrDefault();
        }
    }
}
