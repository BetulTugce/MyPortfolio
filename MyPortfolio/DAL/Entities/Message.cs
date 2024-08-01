using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Entities
{
    public class Message : BaseEntity
    {
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
    }
}
