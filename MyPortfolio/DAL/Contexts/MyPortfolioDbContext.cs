using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Contexts
{
    public class MyPortfolioDbContext : DbContext
    {
        #region Veritabanı Bağlantısı için Yapılandırma
        //Daha iyi bir yaklaşım olması açısından connection string appsettings.json dosyasında tanımlandı ve Program.cs üzerinde DbContext yapılandırması gerçekleştirildi..
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //base.OnConfiguring(optionsBuilder);
        //optionsBuilder.UseSqlServer("Server=your_server_name;Database=your_db_name;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True;");
        //}
        #endregion

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
