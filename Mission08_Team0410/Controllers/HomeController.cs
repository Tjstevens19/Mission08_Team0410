using Microsoft.AspNetCore.Mvc;
using Mission08_Team0410.Models;
using System.Diagnostics;
using System.Linq;

namespace Mission08_Team0410.Controllers
{
    public class HomeController : Controller
    {
        private iTaskRepository _repo;
        public HomeController(iTaskRepository temp)
        {
            _repo = temp;
        }
        }

        }

        }

        public IActionResult Index()
        {
            return View();
        [HttpGet]
        public IActionResult AddTask()

        public IActionResult Privacy()
        {
            ViewBag.Tasks = _repo.Tasks;
            return base.View("AddTask", new Models.Task());
        }
        [HttpPost]
        public IActionResult AddTask(Models.Task newtask)
        {
            _repo.AddTask(newtask);
            return RedirectToAction("Index");
        }




        [HttpPost]
        public IActionResult AddTask(TaskClass newtask)
        {
            _repo.AddTask(newtask);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult UpdateTask(int id)
        //{
            //Models.Task task = _repo.Tasks.FirstOrDefault((System.Threading.Tasks.Task t) => t.TaskID == id);
            //return View(task);
        //}
        [HttpPost]
        public IActionResult UpdateTask(Models.Task task)
        {
            _repo.UpdateTask(task);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult DeleteTask(int id)
        //{
        //    _repo.DeleteTask(id);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult DeleteTask(Models.Task task)
        {
            _repo.DeleteTask(task);
            return RedirectToAction("Index");
        }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
