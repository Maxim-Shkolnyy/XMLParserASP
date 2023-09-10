using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Entities;

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
            var settingList = _db.SupplierXmlSettings.ToList();
            ViewBag.settingViewBag = settingList;

            return View();
        }

        [HttpPost]
        public IActionResult UpdatePriceQuantity()
        {
            

            return View();
        }
    }
}
