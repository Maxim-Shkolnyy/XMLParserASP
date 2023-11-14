using Microsoft.AspNetCore.Mvc;

namespace xmlParserASP.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
        }



    }

    public class RegisterViewModel
    {
    }
}
