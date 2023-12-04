using Microsoft.AspNetCore.Mvc;

namespace TigerPadProj.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View("SignUp");
        }
        public IActionResult UserLogin()
        {
            return View("UserLogin");
        }

        public IActionResult AdminLogin()
        {
            return View("AdminLogin");
        }

        public IActionResult About()
        {
            return View("About");
        }
    }
}
