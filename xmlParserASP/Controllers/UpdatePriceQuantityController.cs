using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;
using xmlParserASP.Models;
using xmlParserASP.Services;


namespace xmlParserASP.Controllers
{
    public class UpdatePriceQuantityController : Controller
    {
        private readonly MyDBContext _db;
        private readonly SupplierXmlSetting _setting;
        private readonly UpdatePriceQuantityService _updatePriceQuantityService;
        public UpdatePriceQuantityController(MyDBContext db, SupplierXmlSetting setting, UpdatePriceQuantityService updatePriceQuantityService)
        {
            _db = db;
            _setting = setting;
            _updatePriceQuantityService = updatePriceQuantityService;
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
        public IActionResult Result(List<int>? PriceList, List<int>? QuantityList)
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

            if (PriceList.Count != 0)
            {
                var updateAllPrices = _updatePriceQuantityService.UpdatePrice(PriceList);
            }

            if (QuantityList.Count != 0)
            {
                var updateAllQuantity = _updatePriceQuantityService.UpdateQuantity(QuantityList);
            }



            return View();
        }
    }
}
