using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string SubDescription { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
    }
}
