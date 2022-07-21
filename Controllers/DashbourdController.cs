using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmisionApplication.Controllers
{
    public class DashbourdController : Controller
    {
        public IActionResult dashbourd()
        {
            return View();
        }
    }
}
