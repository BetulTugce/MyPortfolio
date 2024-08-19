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

        // Mesajların okundu durumu ne ise tersi ile değiştirir..
        public IActionResult MarkAsRead(int messageId)
        {
            var message = _context.Messages.Find(messageId);
            if (message != null && !message.IsRead)
            {
                message.IsRead = true;
                _context.SaveChanges();
            }
            else if (message != null && message.IsRead) 
            {
                message.IsRead = false;
                _context.SaveChanges();
            }
            return RedirectToAction("Inbox");
        }
    }
}
