using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;

namespace xmlParserASP.Controllers
{
    public class ProcessXMLController : Controller
    {
        private readonly MyDBContext _db;
        private readonly ReadAttrFromXmlTo3ColumnsRU _readAttrFromXmlTo3ColumnsRU;
        private readonly ReadAttrFromXmlTo3ColumnsUA _readAttrFromXmlTo3ColumnsUA;
        private readonly WriteToXL _writeToXL;
        private readonly WriteRuToXL _writeToRuToXL;
        private readonly UniqNodesInXML _uniqNodesInXML;
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
        public IActionResult ProcessUnload(int selectedSupplierXmlSetting, string? paramAttr)
        {
            _uniqNodesInXML.Read(selectedSupplierXmlSetting);

            var suppSetting = _db.SupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId==selectedSupplierXmlSetting);
            if (suppSetting != null)
            {
                if (PathModel.Language == Language.Ua)
                {
                    _readAttrFromXmlTo3ColumnsUA.ReadAttrTo3(selectedSupplierXmlSetting);

                    _writeToXL.WriteSheet(selectedSupplierXmlSetting);
                }
                else
                {
                    var writeToXLru = new WriteRuToXL(_db);
                    writeToXLru.WriteRuColumnsToXL(selectedSupplierXmlSetting);

                    _readAttrFromXmlTo3ColumnsRU.ReadAttrto3ru(selectedSupplierXmlSetting);
                }
            }

            return View();
        }
    }
}
