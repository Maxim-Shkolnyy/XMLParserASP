using Microsoft.EntityFrameworkCore;
//using xmlParserASP.Entities.TestGamma.OldMy;

namespace xmlParserASP.Presistant;

//public class MyDBContext : DbContext
//{
//    public MyDBContext(DbContextOptions<MyDBContext> options)
//    : base(options) { }

//    public DbSet<MyAttribute> MyAttributes { get; set; }
//    public DbSet<SupplierAttribute> SupplierAttributes { get; set; }

//    public DbSet<MyCategory> MyCategories { get; set; }
//    public DbSet<SupplierCategory> SupplierCategories { get; set; }

//    public DbSet<Supplier> Suppliers { get; set; }
//    public DbSet<Product> Products { get; set; }
//    public DbSet<SupplierXmlSetting> SupplierXmlSettings { get; set; }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        base.OnModelCreating(modelBuilder);

//        modelBuilder.Entity<MyAttribute>()
//            .HasMany(m => m.SupplierAttributes)
//            .WithMany(c => c.MyAttributes)
//            .UsingEntity(j=>j.ToTable("my_attributes_supplier_attributes"));

//        modelBuilder.Entity<MyCategory>()
//            .HasMany(n => n.SupplierCategories)
//            .WithMany(j => j.MyCategories)
//            .UsingEntity(k => k.ToTable("my_categories_supplier_categories"));

       


//    }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        base.OnConfiguring(optionsBuilder);
//        optionsBuilder.UseSnakeCaseNamingConvention();
//    }

    
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    IConfigurationRoot configuration = new ConfigurationBuilder()
    //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    //        .AddJsonFile("appsettings.json")
    //        .Build();
    //   // optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

    //    //string connectionString = "Server=MAX\\SQLEXPRESS;Database=MAX;Integrated Security=True;TrustServerCertificate=True" // home desktop
    //    //string connectionString = "Server=(localdb)\\Local;Database=MAX;Integrated Security=True" // home notebook   
    //    //string connectionString = "Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MAX;Trusted_Connection=True;TrustServerCertificate=True" // work desktop 
    //    string connectionString =
    //        "Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;";

    //    bool isConnected = Database.CanConnect();
    //    Database.EnsureCreated();

    //}
    // створити всі абстракції таблиць із існуючої бд
    //  dotnet ef dbcontext scaffold "Database=zi391919_sandboxgamma;Data Source=zi391919.mysql.tools;User Id=zi391919_sandboxgamma;Password=!6km4kKY_9;" MySql.EntityFrameworkCore -o Entities/GammaTables;
//}

