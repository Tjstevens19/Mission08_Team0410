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
        public IActionResult Index()
        {
            var Tasks = _repo.Tasks;
                //.Include(x => x.Category);
            return View(Tasks);
            
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _repo.Categories;
            return View("AddTask", new Models.CoveyTask());
        }

        [HttpPost]
        public IActionResult AddTask(Models.CoveyTask newtask)
        {
            _repo.AddTask(newtask);
            return RedirectToAction("Index", newtask);
        }

        [HttpGet]
        public IActionResult UpdateTask(int id)
        {
            var recordToUpdate = _repo.Tasks.FirstOrDefault(t => t.TaskId == id);
            ViewBag.Categories = _repo.Categories;
            return View("AddTask", recordToUpdate);
        }

        [HttpPost]
        public IActionResult UpdateTask(Models.CoveyTask task)
        {
            _repo.UpdateTask(task);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteTask(int id)
        {
            var recordToDelete = _repo.Tasks.FirstOrDefault(t => t.TaskId == id);
            ViewBag.Categories = _repo.Categories;
            return View("DeleteTask", recordToDelete);

        }

        [HttpPost]
        public IActionResult DeleteTask(Models.CoveyTask task)
        {
            _repo.DeleteTask(task);
            return RedirectToAction("Index");
        }

        }
    }
