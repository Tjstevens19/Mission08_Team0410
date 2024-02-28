using Microsoft.AspNetCore.Mvc;
using Mission08_Team0410.Models;
using System.Diagnostics;

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
            return View("AddTask", new TaskClass());
        }
        //[HttpPost]
        //public IActionResult AddTask(TaskClass newtask)
        //{
        //    _repo.AddTask(newtask);
        //    return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public IActionResult UpdateTask(int id)
        //{
        //    TaskClass task = _repo.Tasks.FirstOrDefault(t => t.TaskID == id);
        //    return View(task);
        //}
        //[HttpPost]
        //public IActionResult UpdateTask(TaskClass task)
        //{
        //    _repo.UpdateTask(task);
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult DeleteTask(int id)
        //{
        //    _repo.DeleteTask(id);
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public IActionResult DeleteTask(TaskClass task)
        //{
        //    _repo.DeleteTask(task);
        //    return RedirectToAction("Index");
        //}

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
