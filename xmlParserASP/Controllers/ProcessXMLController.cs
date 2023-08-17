using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;

namespace xmlParserASP.Controllers
{
    public class ProcessXMLController : Controller
    {
        private MyDBContext _db;
        public ProcessXMLController(MyDBContext db)
        {
            _db=db;  
        }
        public IActionResult Index()
        {
            var myContext = _db.SupplierXmlSettings;

            var model = new DownloadPhotosViewModel
            {
                SupplierXmlSettings = _db.SupplierXmlSettings.ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ProcessUnload(int? settingId, string? paramAttr)
        {
            UniqNodesInXML.Read();

            var param = _db.SupplierXmlSettings.FirstOrDefault(s => s.paramAttribute == paramAttr);
            if (param != null)
            {

            }

            if (PathModel.Language == Language.Ua)
            {
                var rAtr = new ReadAttrFromXmlTo3ColumnsUA();
                rAtr.ReadAttrTo3();

                var writeToXL = new WriteToXL(_db);
                writeToXL.WriteSheet();
            }
            else
            {
                var writeToXLru = new WriteRuToXL(_db);
                writeToXLru.WriteRuColumnsToXL();

                var rAtr = new ReadAttrFromXmlTo3ColumnsRU();
                rAtr.ReadAttrto3ru();
            }

            return View();
        }
    }
}
