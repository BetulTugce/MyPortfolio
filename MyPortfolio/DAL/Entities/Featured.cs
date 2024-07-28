using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Featured : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
