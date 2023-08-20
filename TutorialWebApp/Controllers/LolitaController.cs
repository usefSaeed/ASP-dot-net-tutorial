using Microsoft.AspNetCore.Mvc;

namespace TutorialWebApp.Controllers
{
    public class LolitaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
