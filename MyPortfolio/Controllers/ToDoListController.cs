using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly MyPortfolioDbContext _context;

        public ToDoListController(MyPortfolioDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            _context.ToDoLists.Add(toDoList);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int taskId)
        {
            var value = _context.ToDoLists.Find(taskId);
            _context.ToDoLists.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int taskId)
        {
            var value = _context.ToDoLists.Find(taskId);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            _context.ToDoLists.Update(toDoList);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatus(int taskId)
        {
            var value = _context.ToDoLists.Find(taskId);
            if (value != null && !value.Status)
            {
                value.Status = true;
                _context.SaveChanges();
            }
            else if (value != null && value.Status)
            {
                value.Status = false;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
