using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.AppHosting;

namespace xmlParserASP.Presistant
{
    public class AppHostingContext : IdentityDbContext
    {
        public AppHostingContext(DbContextOptions<AppHostingContext> contextOptions) : base(contextOptions)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("YourConnectionString")
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        public virtual DbSet<MmSupplier> MmSuppliers { get; set; }

        public virtual DbSet<MmSupplierXmlSetting> MmSupplierXmlSettings { get; set; }

        public virtual DbSet<MmProductsManualSetPrice> ProductsManualSetPrices { get; set; }

        public virtual DbSet<MmProductsManualSetQuanity> ProductsManualSetQuanitys { get; set; }

        public virtual DbSet<MmProductsSetQuantityWhenMin> ProductsSetQuantityWhenMin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
        }        
    }
}
