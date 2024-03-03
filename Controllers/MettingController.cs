using Microsoft.AspNetCore.Mvc;

namespace MettingApp.Controllers
{
    public class MettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 

        public IActionResult Apply(){
            return View();
        }

        public IActionResult List(){
            return View();
        }
    }
}