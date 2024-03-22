using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class NgProductsController : Controller
{
    private readonly GammaContext _context;
    private MmSupplierXmlSetting _suppSetting;
    private string? _suppName;

    public NgProductsController(GammaContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.NgCategoryDescriptions.Where(m => m.LanguageId == 3).ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> GetProducts(int? SelectedCategoryId)
    {
        List<int> childrenCategories = new();

        if (SelectedCategoryId != null)
        {
            childrenCategories = await _context.NgCategories.Where(m => m.ParentId == SelectedCategoryId).Select(n => n.CategoryId).ToListAsync();
            childrenCategories.Insert(0, (int)SelectedCategoryId);
        }
        else
        {
            childrenCategories = await _context.NgCategories.Select(m => m.CategoryId).ToListAsync();
        }

        List<int> productsIdsOfCurrentCategory = new();

        //if (selectedSupplierXmlSetting == null)
        //{
        //    //Todo: get all products
        //    productsIdsOfCurrentCategory = _context.NgProductToCategories.Where(m => childrenCategories.Contains(m.CategoryId)).Select(c => c.ProductId).ToList();
        //}
        //else
        //{
            //_suppSetting = await _context.MmSupplierXmlSettings.FirstOrDefaultAsync(s => s.SupplierXmlSettingId == selectedSupplierXmlSetting);
            //_suppName = await _context.MmSuppliers.Where(m => m.SupplierId == _suppSetting.SupplierId).Select(n => n.SupplierName).FirstOrDefaultAsync();

            productsIdsOfCurrentCategory =await _context.NgProductToCategories.Where(m => childrenCategories.Contains(m.CategoryId)).Select(c => c.ProductId).ToListAsync();

            var selectedProducts = await _context.NgProducts.Where(m => productsIdsOfCurrentCategory.Contains(m.ProductId)).Select(n => new
                ProductMinInfoModel
                {
                    ProductId = n.ProductId,
                    Model = n.Model, 
                    Sku = n.Sku, 
                    Quantity = n.Quantity, 
                    Price = n.Price
                } ).ToListAsync();

            var specials = await _context.NgProductSpecials.Where(m => productsIdsOfCurrentCategory.Contains(m.ProductId))
                .Select(n => new
                {
                    n.ProductId,
                    n.Price
                }).ToListAsync();
            var discounts = await _context.NgProductDiscounts.Where(m => productsIdsOfCurrentCategory.Contains(m.ProductId))
                .Select(m => new
                {
                    m.ProductId,
                    m.Price
                })
                .ToListAsync();

            //if(selectedProducts.Contains(specials.ProductId)
            //{

            //}

            return View(selectedProducts);
        //}

        //return View(new EmptyResult());
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