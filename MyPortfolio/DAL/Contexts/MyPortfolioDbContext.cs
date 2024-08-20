using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;
using MyPortfolio.DAL.Entities.Common;

namespace MyPortfolio.DAL.Contexts
{
    public class MyPortfolioDbContext : DbContext
    {
        public MyPortfolioDbContext(DbContextOptions<MyPortfolioDbContext> options):base(options) { }

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
        public DbSet<Notification> Notifications { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entity Framework tarafından sağlanan bir özelliktir. Entityler üzerinden yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.
            var datas = ChangeTracker
                 .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    // Eğer entity ekleniyorsa, CreatedDate'i şu anki zaman ile ayarlar..
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    // Eğer entity güncelleniyorsa, UpdatedDate'i şu anki zaman ile ayarlar.
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
