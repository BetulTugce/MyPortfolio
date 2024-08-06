using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly MyPortfolioDbContext _context;
        public ExperienceController(MyPortfolioDbContext context)
        {
            _context = context;
        }
        public IActionResult ExperienceList()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }

        // Sayfa yüklenince çalışacak..
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        
        // Sayfada bir butona tıklandığında çalışacak..
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            _context.Experiences.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
