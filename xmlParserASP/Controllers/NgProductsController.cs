using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class NgProductsController : Controller
{
    private readonly GammaContext _context;
    private readonly DownloadPhotosViewModel _model;
    private MmSupplierXmlSetting _suppSetting;
    private string? suppName;

    public NgProductsController(GammaContext context)
    {
        _context = context;
    }

    // GET: NgProducts
    public async Task<IActionResult> Index()
    {
        return View(await _context.NgCategoryDescriptions.Where(m => m.LanguageId == 3).ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> GetProducts(int? selectedSupplierXmlSetting, int? SelectedCategoryId, bool Rename, string? desktopSubFolder, string? LinkPrefix)
    {
        List<int> childrenCategories = new();

        if (SelectedCategoryId != null)
        {
            childrenCategories = _model.NgCategorys.Where(m => m.ParentId == SelectedCategoryId).Select(n => n.CategoryId).ToList();
            childrenCategories.Insert(0, (int)SelectedCategoryId);
        }
        else
        {
            childrenCategories = _model.NgCategorys.Select(m => m.CategoryId).ToList();
        }

        List<int> productsIdsOfCurrentCategory = new();

        if (selectedSupplierXmlSetting == null)
        {
            productsIdsOfCurrentCategory = _model.NgProductToCategories.Where(m => childrenCategories.Contains(m.CategoryId)).Select(c => c.ProductId).ToList();
        }
        else
        {
            //Todo: get all products

            _suppSetting = await _context.MmSupplierXmlSettings.FirstOrDefaultAsync(s => s.SupplierXmlSettingId == selectedSupplierXmlSetting);
            suppName = await _context.MmSuppliers.Where(m => m.SupplierId == _suppSetting.SupplierId).Select(n => n.SupplierName).FirstOrDefaultAsync();

            productsIdsOfCurrentCategory = _model.NgProductToCategories.Where(m => childrenCategories.Contains(m.CategoryId)).Select(c => c.ProductId).ToList();

            var selectedProducts = await _context.NgProducts.Where(m => productsIdsOfCurrentCategory.Contains(m.ProductId)).ToListAsync();

            return View(selectedProducts);
        }

        return View(new EmptyResult()); // Повернення за замовчуванням, якщо умови не виконуються
    }



    // GET: NgProducts/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ngProduct = await _context.NgProducts
            .FirstOrDefaultAsync(m => m.ProductId == id);
        if (ngProduct == null)
        {
            return NotFound();
        }

        return View(ngProduct);
    }

    // GET: NgProducts/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NgProducts/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ProductId,Model,Sku,Upc,Ean,Jan,Isbn,Mpn,Location,Quantity,StockStatusId,Image,ManufacturerId,Shipping,Price,Points,TaxClassId,DateAvailable,Weight,WeightClassId,Length,Width,Height,LengthClassId,Subtract,Minimum,SortOrder,Status,Viewed,DateAdded,DateModified,Noindex,Cost")] NgProduct ngProduct)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ngProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ngProduct);
    }

    // GET: NgProducts/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ngProduct = await _context.NgProducts.FindAsync(id);
        if (ngProduct == null)
        {
            return NotFound();
        }
        return View(ngProduct);
    }

    // POST: NgProducts/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("ProductId,Model,Sku,Upc,Ean,Jan,Isbn,Mpn,Location,Quantity,StockStatusId,Image,ManufacturerId,Shipping,Price,Points,TaxClassId,DateAvailable,Weight,WeightClassId,Length,Width,Height,LengthClassId,Subtract,Minimum,SortOrder,Status,Viewed,DateAdded,DateModified,Noindex,Cost")] NgProduct ngProduct)
    {
        if (id != ngProduct.ProductId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ngProduct);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NgProductExists(ngProduct.ProductId))
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
        return View(ngProduct);
    }

    // GET: NgProducts/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var ngProduct = await _context.NgProducts
            .FirstOrDefaultAsync(m => m.ProductId == id);
        if (ngProduct == null)
        {
            return NotFound();
        }

        return View(ngProduct);
    }

    // POST: NgProducts/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var ngProduct = await _context.NgProducts.FindAsync(id);
        if (ngProduct != null)
        {
            _context.NgProducts.Remove(ngProduct);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NgProductExists(int id)
    {
        return _context.NgProducts.Any(e => e.ProductId == id);
    }
}