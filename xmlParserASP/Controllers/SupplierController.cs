using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;

namespace xmlParserASP.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDBContext _db;

        public SupplierController(ILogger<HomeController> logger, MyDBContext db)
        {
            _db = db;
            _logger = logger;
        }
        public IActionResult Suppliers()
        {
            return View(_db.Suppliers);
        }
    }
}
