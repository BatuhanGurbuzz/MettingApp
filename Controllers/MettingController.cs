using Microsoft.AspNetCore.Mvc;

namespace MettingApp.Controllers
{
    public class MettingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 

        [HttpGet]    
        public IActionResult Apply(){
            return View();
        }

        
        [HttpPost]    
        public IActionResult Apply(string Name, string Phone, string Email, bool WillAttend){
            return View();
        }

        [HttpGet]
        public IActionResult List(){
            return View();
        }
    }
}