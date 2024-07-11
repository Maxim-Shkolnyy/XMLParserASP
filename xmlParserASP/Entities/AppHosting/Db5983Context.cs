using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace xmlParserASP.Entities.AppHosting;

public partial class Db5983Context : DbContext
{
    public Db5983Context()
    {
    }

    public Db5983Context(DbContextOptions<Db5983Context> options)
        : base(options)
    {
    }

    public virtual DbSet<IdentityRole> IdentityRoles { get; set; }

    public virtual DbSet<IdentityRoleClaimString> IdentityRoleClaimStrings { get; set; }

    public virtual DbSet<IdentityUser> IdentityUsers { get; set; }

    public virtual DbSet<IdentityUserClaimString> IdentityUserClaimStrings { get; set; }

    public virtual DbSet<IdentityUserLoginString> IdentityUserLoginStrings { get; set; }

    public virtual DbSet<IdentityUserRoleString> IdentityUserRoleStrings { get; set; }

    public virtual DbSet<IdentityUserTokenString> IdentityUserTokenStrings { get; set; }

    public virtual DbSet<MmSupplier> MmSuppliers { get; set; }

    public virtual DbSet<MmSupplierXmlSetting> MmSupplierXmlSettings { get; set; }

    public virtual DbSet<ProductsManualSetPrice> ProductsManualSetPrices { get; set; }

    public virtual DbSet<ProductsManualSetQuanity> ProductsManualSetQuanitys { get; set; }

    public virtual DbSet<ProductsSetQuantityWhenMin> ProductsSetQuantityWhenMins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=db5983.public.databaseasp.net;Database=db5983;User Id=db5983;Password=Ta83LeZr5;Encrypt=False;MultipleActiveResultSets=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>(entity =>
        {
            entity.ToTable("IdentityRole");
        });

        modelBuilder.Entity<IdentityRoleClaimString>(entity =>
        {
            entity.ToTable("IdentityRoleClaim<string>");
        });

        modelBuilder.Entity<IdentityUser>(entity =>
        {
            entity.ToTable("IdentityUser");
        });

        modelBuilder.Entity<IdentityUserClaimString>(entity =>
        {
            entity.ToTable("IdentityUserClaim<string>");
        });

        modelBuilder.Entity<IdentityUserLoginString>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IdentityUserLogin<string>");
        });

        modelBuilder.Entity<IdentityUserRoleString>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IdentityUserRole<string>");
        });

        modelBuilder.Entity<IdentityUserTokenString>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IdentityUserToken<string>");
        });

        modelBuilder.Entity<MmSupplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId);

            entity.Property(e => e.SupplierName).HasMaxLength(20);
        });

        modelBuilder.Entity<MmSupplierXmlSetting>(entity =>
        {
            entity.HasKey(e => e.SupplierXmlSettingId);

            entity.Property(e => e.QuantityDbStock1).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock2).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock3).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock4).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock5).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock6).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock7).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock8).HasMaxLength(20);
            entity.Property(e => e.QuantityDbStock9).HasMaxLength(20);
        });

        modelBuilder.Entity<ProductsManualSetPrice>(entity =>
        {
            entity.Property(e => e.SetInStockPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sku).HasMaxLength(7);
        });

        modelBuilder.Entity<ProductsManualSetQuanity>(entity =>
        {
            entity.Property(e => e.SetInStockQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sku).HasMaxLength(7);
        });

        modelBuilder.Entity<ProductsSetQuantityWhenMin>(entity =>
        {
            entity.ToTable("ProductsSetQuantityWhenMin");

            entity.Property(e => e.Sku).HasMaxLength(7);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
