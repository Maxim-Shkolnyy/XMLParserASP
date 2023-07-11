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
            
        return View(_db.MyAttributes);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ProcessExcel()
    {

        var rAtr = new ReadAttributesTo3Columns();
        var writeToXL = new WriteToXL(_db);
        //var myDb = serviceProvider.GetService<MyDBContext>();

        rAtr.ReadAttrXMLTo3Columns();
        writeToXL.WriteSheet("ru");  // ua

        //UniqNodesInXML.Read();


        return new EmptyResult();
    }

    public IActionResult Suppliers()
    {
        return View(_db.Suppliers);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}