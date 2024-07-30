using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        private readonly MyPortfolioDbContext _context;

        public _FeatureComponentPartial(MyPortfolioDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        { 
            var values = _context.Features.ToList();
            return View(values); 
        }
    }
}
