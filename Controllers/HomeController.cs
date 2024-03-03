using Microsoft.AspNetCore.Mvc;

namespace MettingApp.Controllers{
    public class HomeController : Controller{
        public IActionResult Index()
        {
            return View();
        }
    }
}