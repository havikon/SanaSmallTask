using Microsoft.AspNetCore.Mvc;
using SmallTask.Models;
using System.Diagnostics;

namespace SmallTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HelloModel());
        }

        [HttpPost]
        public IActionResult Index(HelloModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            return View(new HelloModel());
        }
    }
}