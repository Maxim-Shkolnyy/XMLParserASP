using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;

namespace xmlParserASP.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MyDBContext _db;

    public HomeController(ILogger<HomeController> logger, MyDBContext db)
    {
        _db = db;
        _logger = logger;
    }

    public IActionResult Index()
    {
            
        //return View(_db.MyAttributes);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ProcessExcel()
    {
        UniqNodesInXML.Read();

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
        
        
        
        //var myDb = serviceProvider.GetService<MyDBContext>();       

        return View("Unloading");
    }

    //public IActionResult Suppliers()
    //{
    //    return View(_db.Suppliers);
    //}


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}