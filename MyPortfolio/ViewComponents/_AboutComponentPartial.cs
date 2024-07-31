using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contexts;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly MyPortfolioDbContext _context;
        public _AboutComponentPartial(MyPortfolioDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke() 
        { 
            ViewBag.aboutTitle = _context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = _context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutSubTitle = _context.Abouts.Select(x => x.SubTitle).FirstOrDefault();
            ViewBag.aboutContent = _context.Abouts.Select(x => x.Content).FirstOrDefault();
            return View(); 
        }
    }
}
