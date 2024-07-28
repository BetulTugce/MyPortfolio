using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Skill : BaseEntity
    {
        public string Title { get; set; }
        public int Value { get; set; }
    }
}
