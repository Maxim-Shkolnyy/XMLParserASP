using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace XMLparser.Presistant;

public class MyDBContext : DbContext
{
    public DbSet<TablesModels.MyAttribute> MyAttributes { get; set; }
    public DbSet<TablesModels.Category> Categories { get; set; }
    public DbSet<TablesModels.Language> Languages { get; set; }
    public DbSet<TablesModels.Supplier> Suppliers { get; set; }

    public MyDBContext(DbContextOptions<MyDBContext> options)
    : base(options)
    {
            
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
       // optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        //string connectionString = "Server=MAX\\SQLEXPRESS;Database=MAX;Integrated Security=True;TrustServerCertificate=True" // home desktop
        //string connectionString = "Server=(localdb)\\Local;Database=MAX;Integrated Security=True" // home notebook   
        //string connectionString = "Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MAX;Trusted_Connection=True;TrustServerCertificate=True" // work desktop 
        string connectionString =
            "Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;";

        bool isConnected = Database.CanConnect();
        Database.EnsureCreated();
   
    }
}

