using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        private readonly MyPortfolioDbContext _context;

        public _TestimonialComponentPartial(MyPortfolioDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _context.Testimonials.ToList();
            return View(values); 
        }
    }
}
