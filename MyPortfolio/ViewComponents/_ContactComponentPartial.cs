using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        private readonly MyPortfolioDbContext _context;

        public _ContactComponentPartial(MyPortfolioDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var value = _context.Contacts.FirstOrDefault();
            return View(value); 
        }
    }
}
