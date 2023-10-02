using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class MyAttributesController : Controller
{
    private readonly MyDBContext _db;

    public MyAttributesController(MyDBContext context)
    {
        _db = context;
    }

    // GET: MyAttributes
    public async Task<IActionResult> Index()
    {
          return _db.MyAttributes != null ? 
                      View(await _db.MyAttributes.ToListAsync()) :
                      Problem("Entity set 'MyDBContext.MyAttributes'  is null.");
    }

    public ActionResult Attributes()
    {

        var model = new List<MyAttributeViewModel>();

        foreach (MyAttribute dbMyAttribute in _db.MyAttributes)
        {

            var viewAttribute = new MyAttributeViewModel
            {
                MyAttributeId = dbMyAttribute.MyAttrId,
                MyAttributeNameRU = dbMyAttribute.MyAttrNameRU,
                MyAttributeNameUA = dbMyAttribute.MyAttrNameUA

            };

            model.Add(viewAttribute);

        }

        List<SupplierAttributeViewModel> SupplierAttributes = new List<SupplierAttributeViewModel>();
        foreach (SupplierAttribute dbSupplierAttribute in _db.SupplierAttributes)
        {

            var bagAttribute = new SupplierAttributeViewModel
            {
                SupplierAttributeId = dbSupplierAttribute.SupAttrId,
                SupplierAttributeName = dbSupplierAttribute.SupAttrNameRU
                //SupplierAttributeName = dbSupplierAttribute.SupAttrNameRU

            };

            SupplierAttributes.Add(bagAttribute);

        }
        ViewBag.SupplierAttributes = SupplierAttributes;


        return View(model);
    }

    [HttpPost]
    public ActionResult Attributes(MyAttributeViewModel[] saveattributes)
    {

        return new EmptyResult();

        //1 идти по списку
        // для каждого єk брать ID
        // firsr or deafault для кажого елемента. Если нет- new .. Add() ессли есть то SupplierArrtId = 
        //save changes
        //
    }

    // GET: MyAttributes/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _db.MyAttributes == null)
        {
            return NotFound();
        }

        var myAttribute = await _db.MyAttributes
            .FirstOrDefaultAsync(m => m.MyAttrId == id);
        if (myAttribute == null)
        {
            return NotFound();
        }

        return View(myAttribute);
    }

    // GET: MyAttributes/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: MyAttributes/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("MyAttrId,MyAttrNameRU,MyAttrNameUA,MyAttrGroup")] MyAttribute myAttribute)
    {
        if (ModelState.IsValid)
        {
            _db.Add(myAttribute);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(myAttribute);
    }

    // GET: MyAttributes/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _db.MyAttributes == null)
        {
            return NotFound();
        }

        var myAttribute = await _db.MyAttributes.FindAsync(id);
        if (myAttribute == null)
        {
            return NotFound();
        }
        return View(myAttribute);
    }

    // POST: MyAttributes/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("MyAttrId,MyAttrNameRU,MyAttrNameUA,MyAttrGroup")] MyAttribute myAttribute)
    {
        if (id != myAttribute.MyAttrId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _db.Update(myAttribute);
                await _db.SaveChangesAsync();
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

    // GET: MyAttributes/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _db.MyAttributes == null)
        {
            return NotFound();
        }

        var myAttribute = await _db.MyAttributes
            .FirstOrDefaultAsync(m => m.MyAttrId == id);
        if (myAttribute == null)
        {
            return NotFound();
        }

        return View(myAttribute);
    }

    // POST: MyAttributes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_db.MyAttributes == null)
        {
            return Problem("Entity set 'MyDBContext.MyAttributes'  is null.");
        }
        var myAttribute = await _db.MyAttributes.FindAsync(id);
        if (myAttribute != null)
        {
            _db.MyAttributes.Remove(myAttribute);
        }
        
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool MyAttributeExists(int id)
    {
      return (_db.MyAttributes?.Any(e => e.MyAttrId == id)).GetValueOrDefault();
    }
}
