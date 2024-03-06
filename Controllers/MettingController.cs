using MettingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MettingApp.Controllers
{
    public class MettingController : Controller
    {
        [HttpGet]    
        public IActionResult Apply(){
            return View();
        }

        
        [HttpPost]    
        public IActionResult Apply(UserInfo model){

            if(ModelState.IsValid){
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else{
                return View(model);
            }

        }

        [HttpGet]
        public IActionResult List(){
            return View(Repository.Users);
        }

        public IActionResult Details(int id){

            return View(Repository.GetById(id));
            
        }
    }
}