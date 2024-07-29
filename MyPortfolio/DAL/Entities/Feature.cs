using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Feature : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
