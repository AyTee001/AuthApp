using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
