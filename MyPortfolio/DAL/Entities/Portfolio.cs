using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Portfolio : BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

    }
}
