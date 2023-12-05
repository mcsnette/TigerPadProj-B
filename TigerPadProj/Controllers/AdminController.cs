using Microsoft.AspNetCore.Mvc;

namespace TigerPadProj.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminHomepage()
        {
            return View("AdminHomepage");
        }

        public IActionResult AdminMyPosts()
        {
            return View("AdminMyPosts");
        }

        public IActionResult AdminFollowing()
        {
            return View("AdminFollowing");
        }

        public IActionResult AdminAllPosts()
        {
            return View("AdminAllPosts");
        }

        public IActionResult AdminAllAccounts()
        {
            return View("AdminAllAccounts");
        }
    }
}
