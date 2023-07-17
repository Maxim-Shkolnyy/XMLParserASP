using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Models;
using xmlParserASP.Services;

namespace xmlParserASP.Controllers
{
    public class TrainController : Controller
    {
        public IActionResult Index()
        {
            //UniqNodesInXML.Read();

            //if (PathModel.Language == Language.Ua)
            //{
            //    var rAtr = new ReadAttrFromXmlTo3ColumnsUA();
            //    rAtr.ReadAttrTo3();

            //    var writeToXL = new WriteToXL();
            //    writeToXL.WriteSheet();
            //}
            //else
            //{
            //    var writeToXLru = new WriteRuToXL(_db);
            //    writeToXLru.WriteRuColumnsToXL();

            //    var rAtr = new ReadAttrFromXmlTo3ColumnsRU();
            //    rAtr.ReadAttrto3ru();
            //}



            //var myDb = serviceProvider.GetService<MyDBContext>();       

            return View("Unloading");
        }
    }
}
