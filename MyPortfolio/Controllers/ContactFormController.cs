using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;
using MyPortfolio.DAL.Entities;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
	public class ContactFormController : Controller
	{
		private readonly MyPortfolioDbContext _context;
        public ContactFormController(MyPortfolioDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
			return View();
		}

		// POST: ContactForm/Submit
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Submit(ContactFormViewModel model)
		{
			if (ModelState.IsValid)
			{
				// Veritabanına kaydetme işlemi
				Message message = new Message
				{
					NameSurname = model.NameSurname,
					Email = model.Email,
					Subject = model.Subject,
					Content = model.Content,
					IsRead = false
				};

				// Veritabanına ekleme işlemi yapılıyor
				_context.Messages.Add(message);
				_context.SaveChanges();

                // Form verilerini işleme kodu burada
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }
	}
}
