using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Services;
using xmlParserASP.Services.UpdateServices;


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
    private readonly DataContainer _dc;
    private readonly DataCleaner _cleaner;
    public UpdatePriceQuantityController(GammaContext db, MmSupplierXmlSetting setting, UpdatePriceQuantityService updatePriceQuantityService, PriceQuantityViewModel priceQuantityViewModel, DataContainerSingleton dcS, DataCleaner cleaner)
    {
        _db = db;
        _setting = setting;
        _updatePriceQuantityService = updatePriceQuantityService;
        _priceQuantityViewModel = priceQuantityViewModel;
        _settingsList = _db.MmSupplierXmlSettings.ToList();
        _dc = dcS.Instance;
        _cleaner = cleaner;

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
        //_dc.XmlModelPriceList.Clear();
        //_dc.XmlModelQuantityList.Clear();
        //_dc.SkusToUpdate.Clear();
        

        if (QuantityList.Count == 0) //only prices. WhatToUpdate = 1
        {
            _dc.WhatToUpdate = 1;
            //_cleaner.CleanUp();

            foreach (var suppSetting in PriceList)
            {
                try
                {
                    _dc.CurrentTableDbColumnToUpdate = "Price";
                    updateAllPrices = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(suppSetting);
                    
                    commonMessagesList.AddRange(updateAllPrices);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Price was not updated!!! " + ex.Message);
                    ViewBag.PriceError = "Price was not updated!!!" + ex.Message;
                }
            }
        }
        else if (PriceList.Count == 0) //only quantity. WhatToUpdate = 2
        {
            _dc.WhatToUpdate = 2;
            _cleaner.CleanUp();

            foreach (var suppSetting in QuantityList)
            {
                try
                {
                    _dc.CurrentTableDbColumnToUpdate = "Quantity";
                    updateQuantity = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(suppSetting);
                    
                    commonMessagesList.AddRange(updateQuantity);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Quantity was not updated!!! " + ex.Message);
                    ViewBag.QuantityError = "Quantity was not updated!!! " + ex.Message;
                }
            }
        }
        else if (PriceList.Count > 0 & QuantityList.Count > 0) //both price and quantity. WhatToUpdate = 3
        {
            _dc.WhatToUpdate = 3;

            _cleaner.CleanUp();

            PriceList.Sort();
            QuantityList.Sort();

            int maxId = _settingsList.Select(m => m.SupplierXmlSettingId).ToList().Max();

            for (int i = 1; i < maxId + 1; i++)
            {
                if (PriceList.Contains(i))
                {
                    try
                    {
                        _dc.CurrentTableDbColumnToUpdate = "Price";
                        updateAllPrices = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(i);
                        
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
                        _dc.CurrentTableDbColumnToUpdate = "Quantity";
                        updateQuantity = await _updatePriceQuantityService.MasterUpdatePriceQtyClass(i);
                        
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
