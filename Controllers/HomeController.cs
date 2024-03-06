using MettingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MettingApp.Controllers{
    public class HomeController : Controller{
        public IActionResult Index()
        {   
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "İyi günler":"Günaydın";
            
            int UserCount = ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
            
            var meetingInfo = new MeetingInfo(){
                ID = 1,
                Location = "Adana, Abc kongre merkezi",
                Date = new DateTime(2024,03,20,20,0,0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
    }
}