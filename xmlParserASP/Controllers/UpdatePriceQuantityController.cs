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
    private readonly UpdatePriceQuantityService _updatePriceQuantityService;
    private readonly List<MmSupplierXmlSetting> _settingsList = new();
    private readonly DataContainer _dc;
    private readonly DataCleaner _cleaner;
    public UpdatePriceQuantityController(GammaContext db, UpdatePriceQuantityService updatePriceQuantityService, DataContainerSingleton dcS, DataCleaner cleaner)
    {
        _db = db;
        _updatePriceQuantityService = updatePriceQuantityService;
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
        _dc.SuppNameThatWasUpdatedList.Clear();
        

        if (QuantityList.Count == 0) //only prices. WhatToUpdate = 1
        {
            _dc.WhatToUpdate = 1;

            foreach (var suppSetting in PriceList)
            {
                try
                {
                    _cleaner.CleanUpAll();
                    _dc.CurrentTableDbColumnToUpdate = "Price";
                    await _updatePriceQuantityService.Update(suppSetting);
                    
                    commonMessagesList.AddRange(_dc.StateMessages);
                    commonMessagesList.Add(($"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} updated successful", "green"));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!! " + ex.Message);
                    ViewBag.PriceError = $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!!" + ex.Message;
                }
            }
        }
        else if (PriceList.Count == 0) //only quantity. WhatToUpdate = 2
        {
            _dc.WhatToUpdate = 2;

            foreach (var suppSetting in QuantityList)
            {
                try
                {
                    _cleaner.CleanUpAll();
                    _dc.CurrentTableDbColumnToUpdate = "Quantity";
                    await _updatePriceQuantityService.Update(suppSetting);
                    
                    commonMessagesList.AddRange(_dc.StateMessages);
                    commonMessagesList.Add(($"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} updated successful", "green"));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!! " + ex.Message);
                    ViewBag.QuantityError = $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!! " + ex.Message;
                }
            }
        }
        else if (PriceList.Count > 0 & QuantityList.Count > 0) //both price and quantity. WhatToUpdate = 3
        {
            _cleaner.CleanUpAll();

            _dc.WhatToUpdate = 3;
            PriceList.Sort();
            QuantityList.Sort();

            int maxId = _settingsList.Select(m => m.SupplierXmlSettingId).ToList().Max();

            for (int i = 1; i < maxId + 1; i++)
            {
                if (PriceList.Contains(i))
                {
                    try
                    {
                        _cleaner.CleanUpAll();
                        _dc.CurrentTableDbColumnToUpdate = "Price";
                        await _updatePriceQuantityService.Update(i);
                        
                        commonMessagesList.AddRange(_dc.StateMessages);
                        commonMessagesList.Add(($"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} updated successful", "green"));
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!! " + ex.Message);
                        ViewBag.PriceError = $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!!" + ex.Message;
                    }
                }
                if (QuantityList.Contains(i))
                {
                    try
                    {
                        _cleaner.CleanUpOnlyManualMinLisys();
                        _dc.CurrentTableDbColumnToUpdate = "Quantity";
                        await _updatePriceQuantityService.Update(i);
                        
                        commonMessagesList.AddRange(_dc.StateMessages);
                        commonMessagesList.Add(($"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} updated successful", "green"));
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!! " + ex.Message);
                        ViewBag.QuantityError = $"{_dc.SuppName} {_dc.CurrentTableDbColumnToUpdate} was not updated!!! " + ex.Message;
                    }
                }
            }
        }
        ViewBag.UpdateQuantityResult = commonMessagesList;
        return View();
    }
}
