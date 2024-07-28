using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Contact : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Address { get; set; }
    }
}
