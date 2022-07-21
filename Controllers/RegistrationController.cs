using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmisionApplication.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
