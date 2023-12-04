using Microsoft.AspNetCore.Mvc;

namespace TigerPadProj.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserHomepage()
        {
            return View("UserHomepage");
        }

        public IActionResult UserMyPosts()
        {
            return View("UserMyPosts");
        }

        public IActionResult UserFollowing()
        {
            return View("UserFollowing");
        }
    }
}
