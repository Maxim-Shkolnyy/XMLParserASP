using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Entities.AppHosting;
using xmlParserASP.Entities.Users;

namespace xmlParserASP.Presistant
{
    public class AppHostingContext : IdentityDbContext<IdentityUser>
    {
        public AppHostingContext(DbContextOptions<AppHostingContext> contextOptions) : base(contextOptions)
        {
            
        }

        public virtual DbSet<MmSupplier> MmSuppliers { get; set; }

        public virtual DbSet<MmSupplierXmlSetting> MmSupplierXmlSettings { get; set; }

        public virtual DbSet<MmProductsManualSetPrice> ProductsManualSetPrices { get; set; }

        public virtual DbSet<MmProductsManualSetQuanity> ProductsManualSetQuanitys { get; set; }

        public virtual DbSet<MmProductsSetQuantityWhenMin> ProductsSetQuantityWhenMin { get; set; }

        //public virtual DbSet<Entities.AppHosting.IdentityUser> Users { get; set; }
        //public virtual DbSet<Entities.AppHosting.IdentityRole> Roles { get; set; }
        //public virtual DbSet<IdentityUserRole<string>> UserRoles { get; set; }
        //public virtual DbSet<IdentityUserClaim<string>> UserClaims { get; set; }
        //public virtual DbSet<IdentityUserLogin<string>> UserLogins { get; set; }
        //public virtual DbSet<IdentityUserToken<string>> UserTokens { get; set; }
        //public virtual DbSet<IdentityRoleClaim<string>> RoleClaims { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
        //    modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
        //    modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
        //}        
    }
}
