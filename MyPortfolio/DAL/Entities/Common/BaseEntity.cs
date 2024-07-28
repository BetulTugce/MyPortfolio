namespace MyPortfolio.DAL.Entities.Common
{
    // Örneklendirilmesini engellemek için abstract olarak oluşturdum.
    public abstract class BaseEntity
    {
        // Tüm classlarda bulunacak ortak kolonlar barınıyor..
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
