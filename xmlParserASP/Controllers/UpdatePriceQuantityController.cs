using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;
using xmlParserASP.Models;
using xmlParserASP.Services;


namespace xmlParserASP.Controllers;

public class UpdatePriceQuantityController : Controller
{
    private readonly MyDBContext _db;
    private readonly SupplierXmlSetting _setting;
    private readonly UpdatePriceQuantityService _updatePriceQuantityService;
    private readonly PriceQuantityViewModel _priceQuantityViewModel;
    private List<(string, string)>? updateAllPrices = new();
    private List<(string, string)>? updateQuantity = new();
    public UpdatePriceQuantityController(MyDBContext db, SupplierXmlSetting setting, UpdatePriceQuantityService updatePriceQuantityService, PriceQuantityViewModel priceQuantityViewModel)
    {
        _db = db;
        _setting = setting;
        _updatePriceQuantityService = updatePriceQuantityService;
        _priceQuantityViewModel = priceQuantityViewModel;

    }
    public IActionResult Index()
    {
        var settingList = new PriceQuantityViewModel
        {
            SupplierXmlSettings = _db.SupplierXmlSettings.ToList()
        };

        return View(settingList);
    }

    [HttpPost]
    public async Task<IActionResult> Result(List<int>? PriceList, List<int>? QuantityList)
    {
        if (!ModelState.IsValid || PriceList.Count + QuantityList.Count == 0)
        {
            var mySettingList = new PriceQuantityViewModel
            {
                SupplierXmlSettings = _db.SupplierXmlSettings.ToList()
            };

            ViewBag.SelectSupSetting = "Choose supplier first";

            return View("Index", mySettingList);
        }
        

        if (PriceList != null && PriceList.Any())
        {
            try
            {
                updateAllPrices = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(PriceList, "Price");

                ViewBag.UpdatePriceResult = updateAllPrices;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Price was not updated!!! " + ex.Message);
                ViewBag.PriceError = "Price was not updated!!!" + ex.Message;
            }
        }

        if (QuantityList != null && QuantityList.Any())
        {
            try
            {
                updateQuantity = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(QuantityList, "Quantity");

                ViewBag.UpdateQuantityResult = updateQuantity;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Quantity was not updated!!! " + ex.Message);
                ViewBag.QuantityError = "Quantity was not updated!!! " + ex.Message;
            }
        }

        return View();

    }
}
