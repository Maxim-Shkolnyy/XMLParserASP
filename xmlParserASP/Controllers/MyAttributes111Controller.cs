using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Entities;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers;

public class MyAttributes111Controller : Controller
{

    private readonly ILogger<HomeController> _logger;
    private readonly MyDBContext _db;

    public MyAttributes111Controller(ILogger<HomeController> logger, MyDBContext db)
    {
        _db = db;
        _logger = logger;
    }



    // GET: MyAttributesController
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

}