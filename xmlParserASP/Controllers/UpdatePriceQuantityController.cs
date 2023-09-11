using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;
using xmlParserASP.Models;
using System.Diagnostics;

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
            //var currentProduct = _db.Products.Where(m=>m.ProductId == _supplier.SupplierId && )
            var settingList = new PriceQuantityViewModel
            {
                SupplierXmlSettings = _db.SupplierXmlSettings.ToList()
            };
            

            return View(settingList);
        }

        [HttpPost]
        public IActionResult Result(int supplierXmlSettingId)
        {
            int dfkjs = 10;
            dfkjs++;
            int dfs = supplierXmlSettingId + dfkjs;
            Debug.WriteLine(dfkjs);

            return View();
        }
    }
}
