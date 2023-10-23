using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace xmlParserASP.Controllers
{
    public class ProductsManualSetQuanityController : Controller
    {
        // GET: ProductsManualSetQuanityController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductsManualSetQuanityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsManualSetQuanityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsManualSetQuanityController/Create
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

        // GET: ProductsManualSetQuanityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsManualSetQuanityController/Edit/5
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

        // GET: ProductsManualSetQuanityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsManualSetQuanityController/Delete/5
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
