using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Services;


namespace xmlParserASP.Controllers;

public class UpdatePriceQuantityController : Controller
{
    private readonly GammaContext _db;
    private readonly MmSupplierXmlSetting _setting;
    private readonly UpdatePriceQuantityService _updatePriceQuantityService;
    private readonly PriceQuantityViewModel _priceQuantityViewModel;
    private readonly List<MmSupplierXmlSetting> _settingsList = new();
    private List<(string, string)>? updateAllPrices = new();
    private List<(string, string)>? updateQuantity = new();
    public UpdatePriceQuantityController(GammaContext db, MmSupplierXmlSetting setting, UpdatePriceQuantityService updatePriceQuantityService, PriceQuantityViewModel priceQuantityViewModel)
    {
        _db = db;
        _setting = setting;
        _updatePriceQuantityService = updatePriceQuantityService;
        _priceQuantityViewModel = priceQuantityViewModel;
        _settingsList = _db.MmSupplierXmlSettings.ToList();

    }
    public IActionResult Index()
    {
        var settingList = new PriceQuantityViewModel
        {
            SupplierXmlSettings = _settingsList
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
                SupplierXmlSettings = _db.MmSupplierXmlSettings.ToList()
            };

            ViewBag.SelectSupSetting = "Choose supplier first";

            return View("Index", mySettingList);
        }

        List<(string, string)>? commonMessagesList = new();

        if (QuantityList.Count == 0)
        {
            foreach (var suppSetting in PriceList)
            {
                try
                {
                    updateAllPrices = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(suppSetting, "Price");
                    commonMessagesList.AddRange(updateAllPrices);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Price was not updated!!! " + ex.Message);
                    ViewBag.PriceError = "Price was not updated!!!" + ex.Message;
                }
            }
        }
        else if (PriceList.Count == 0)
        {
            foreach (var suppSetting in QuantityList)
            {
                try
                {
                    updateQuantity = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(suppSetting, "Quantity");
                    commonMessagesList.AddRange(updateQuantity);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Quantity was not updated!!! " + ex.Message);
                    ViewBag.QuantityError = "Quantity was not updated!!! " + ex.Message;
                }
            }
        }
        else if (PriceList.Count > 0 & QuantityList.Count > 0)
        {
            PriceList.Sort();
            QuantityList.Sort();
            
            int maxId = _settingsList.Select(m => m.SupplierXmlSettingId).ToList().Max();

            for (int i = 1; i < maxId; i++)
            {
                if (PriceList.Contains(i))
                {
                    try
                    {
                        updateAllPrices = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(i, "Price");
                        commonMessagesList.AddRange(updateAllPrices);
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Price was not updated!!! " + ex.Message);
                        ViewBag.PriceError = "Price was not updated!!!" + ex.Message;
                    }
                }
                if (QuantityList.Contains(i))
                {
                    try
                    {
                        updateQuantity = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(i, "Quantity");
                        commonMessagesList.AddRange(updateQuantity);
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Quantity was not updated!!! " + ex.Message);
                        ViewBag.QuantityError = "Quantity was not updated!!! " + ex.Message;
                    }
                }
            }
        }
        ViewBag.UpdateQuantityResult = commonMessagesList;
        return View();
    }
}
