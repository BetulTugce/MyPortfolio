using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
		private readonly MyPortfolioDbContext _context;

        public StatisticController(MyPortfolioDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.SkillCount = _context.Skills.Count();
            ViewBag.MessageCount = _context.Messages.Count(i => !i.IsRead);
            ViewBag.ExperienceCount = _context.Experiences.Count();
			return View();
        }
    }
}
