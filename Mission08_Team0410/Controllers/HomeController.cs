using Microsoft.AspNetCore.Mvc;
using Mission08_Team0410.Models;
using System.Diagnostics;

namespace Mission08_Team0410.Controllers
{
    public class HomeController : Controller
    {
        private iBaseballRepository _repo;
        public HomeController(iBaseballRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTask()
        {
            return View();
        }

    }
}
