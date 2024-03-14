using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Services;

namespace xmlParserASP.Controllers;

public class MainXmlController : Controller
{
    private readonly GammaContext _gammaContext;

    public MainXmlController(GammaContext gammaContext)
    {
        _gammaContext = gammaContext;
    }
    // GET: MainXmlController
    public ActionResult Index()
    {
        UpdateMainXml updateMainXml = new(_gammaContext);

        updateMainXml.UpdateGammaXml();

        return View();
    }
}