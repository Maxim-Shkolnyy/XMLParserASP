using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Presistant;
using xmlParserASP.Services;

namespace xmlParserASP.Controllers
{
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

        // GET: MainXmlController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MainXmlController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MainXmlController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainXmlController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MainXmlController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainXmlController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MainXmlController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
