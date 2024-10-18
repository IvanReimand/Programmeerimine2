using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
