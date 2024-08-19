using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;

namespace MyPortfolio.Controllers
{
	public class MessageController : Controller
	{
		private readonly MyPortfolioDbContext _context;

        public MessageController(MyPortfolioDbContext context)
        {
			_context = context;
        }

        public IActionResult Inbox()
		{
			var values = _context.Messages.ToList();
			return View(values);
		}
	}
}
