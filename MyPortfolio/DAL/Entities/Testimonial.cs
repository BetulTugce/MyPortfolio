using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Testimonial : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
