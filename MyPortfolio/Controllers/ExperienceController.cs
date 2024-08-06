using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;

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
    }
}
