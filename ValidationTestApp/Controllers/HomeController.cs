using Microsoft.AspNetCore.Mvc;
using ValidationTestApp.Models;

namespace ValidationTestApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                //write something...
            }

            return View();
        }
    }
}