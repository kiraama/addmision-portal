using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmisionApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }
        public IActionResult forgetpassword()
        {
            return View();
        }
    }
}
