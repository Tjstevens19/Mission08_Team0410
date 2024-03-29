using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
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

        [HttpGet]
        public IActionResult Index()
        {
            var tasksWithCategories = _repo.Tasks.Select(t => _repo.GetTaskById(t.TaskId)).ToList();
            return View(tasksWithCategories);
        }


        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _repo.Categories;

            var newTask = new CoveyTask()
            {
                DueDate = DateTime.Today
            };

            return View("AddTask", newTask);
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
