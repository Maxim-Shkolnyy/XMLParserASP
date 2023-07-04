using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}