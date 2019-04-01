using System.Web.Mvc;
using ProjectManAgmentPlatform.Models;

namespace ProjectManAgmentPlatform.Controllers
{
    public class AuthController : Controller
    {
        // GET
        public ActionResult Login()
        {
            var user = new User() {Name = "Farouk "}; 
            return View(user);
        }

        public ActionResult Signup()
        {
            var user = new User() {Name = "Farouk "};
            return View(user);

        }
    }
}