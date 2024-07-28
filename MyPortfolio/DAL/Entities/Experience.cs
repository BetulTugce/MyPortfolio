using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Experience : BaseEntity
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
