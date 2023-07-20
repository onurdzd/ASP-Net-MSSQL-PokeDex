using Microsoft.EntityFrameworkCore;
using PokeReviewApp.Models;

namespace PokeReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }
        //aşağıdaki db lere erişim sağlıyor
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country>Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Poke>Pokes { get; set; }
        public DbSet<PokeOwner>PokeOwners { get; set; }
        public DbSet<PokeCategory> PokeCategories { get; set; }
        public DbSet<Review> Reviews { get;}
        public DbSet<Reviewer> Reviewers { get;}

        //aşağıdaki kodlar sql den kendin yapmadan query ile yapılması için.microsoft entity framework tools kurduktan sonra aşağıdakileri yazıp sonrasında Package Manager Console açıp Add-Migration InitialCreate yapınca tabloları aşağıya göre oluşturuyor.DAHA SONRASINDA pROGRAM CS İÇERİSİNDE YAPTIĞIMIZ dEFAULTcONNECTİON DOĞRUYSA aşağıya Update-Database yazınca MSSQL de bulunan Poke dbo suda Migration daki gibi güncelleniyor.daha sonra PokeReviewApp içerisine girip terminalden. dotnet run seeddata çalıştıroysun.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokeCategory>()
                .HasKey(c => new { c.PokeId, c.CategoryId });
            modelBuilder.Entity<PokeCategory>()
                .HasOne(p => p.Poke)
                .WithMany(p=>p.PokeCategories)
                .HasForeignKey(p=>p.PokeId);
            modelBuilder.Entity<PokeCategory>()
                .HasOne(p => p.Category)
                .WithMany(p => p.PokeCategories)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<PokeOwner>()
                .HasKey(c => new { c.PokeId, c.OwnerId });
            modelBuilder.Entity<PokeOwner>()
                 .HasOne(p => p.Poke)
                 .WithMany(p => p.PokeOwners)
                 .HasForeignKey(p => p.PokeId);
            modelBuilder.Entity<PokeOwner>()
                .HasOne(p => p.Owner)
                .WithMany(p => p.PokeOwners)
                .HasForeignKey(p => p.OwnerId);
        }
    }
}
