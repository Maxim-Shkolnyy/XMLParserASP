using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;
using xmlParserASP.Models;

namespace xmlParserASP.Controllers
{
    public class UpdatePriceQuantityController : Controller
    {
        private readonly MyDBContext _db;
        private readonly SupplierXmlSetting _setting;
        public UpdatePriceQuantityController(MyDBContext db, SupplierXmlSetting setting)
        {
            _db = db;
            _setting = setting;
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
        public IActionResult Result(List<int>? PriceList, List<int> QuantityList)
        {
            if (ModelState.IsValid)
            {

                if (PriceList.Count + QuantityList.Count == 0)
                {
                    var mySettingList = new PriceQuantityViewModel
                    {
                        SupplierXmlSettings = _db.SupplierXmlSettings.ToList()
                    };

                    ViewBag.SelectSupSetting = "Choose supplier first";

                    return View("Index", mySettingList);
                }
            }

            return View();
        }
    }
}
