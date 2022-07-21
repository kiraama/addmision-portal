using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmisionApplication.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Apps()
        {
            return View();
        }
        public IActionResult process()
        {
            return View();
        }
    }
}
