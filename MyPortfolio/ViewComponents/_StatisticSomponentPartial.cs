using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticSomponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
