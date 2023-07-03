using System;
using System.Configuration;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Presistant;
using xmlParserASP.Services;
//using MySQL.Data.EntityFrameworkCore.Extensions;

namespace xmlParserASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString =
                // "Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MAX;Trusted_Connection=True;TrustServerCertificate=True"; // work desktop
                "Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;"; // gamma max

             var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));

             builder.Services.AddDbContext<MyDBContext>(options =>
                 options.UseMySql(connectionString, serverVersion));
             builder.Services.AddScoped<MyDBContext>(options => options.GetService<MyDBContext>());

            // Add services to the container.
            //builder.Services.AddDbContext<MyDBContext>(options => options.UseMySql( serverVersion));
            //builder.Services.AddDbContextPool<MyDBContext>(options =>
            //{
            //    var connetionString = Configuration.GetConnectionString("DefaultConnection");
            //    options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
            //});

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");






            //var serviceProvider = new ServiceCollection()
            //    .AddSingleton<ReadAttributesTo3Columns>()
            //    .AddTransient<ReadUniqueCategorys>()
            //    .AddSingleton<WriteToXL>()
            //    .AddSingleton<Program>()
            //    .AddSingleton<MyDBContext>()
            //    //.AddSingleton<PathListVarModel>()
            //    .BuildServiceProvider();

            //var rAtr = serviceProvider.GetService<ReadAttributesTo3Columns>();
            //var writeToXL = serviceProvider.GetService<WriteToXL>();
            //var myDb = serviceProvider.GetService<MyDBContext>();

            //rAtr.ReadAttrXMLTo3Columns();
            //writeToXL.WriteSheet("ru");  // ua

            //var rUniq = serviceProvider.GetService<ReadUniqueCategorys>();
            //rUniq.ReadXMLUniqueCategorys();

            //UniqNodesInXML.Read();

            // var model = serviceProvider.GetService<PathListVarModel>();


            //SQLQuery.ConnectToDB();




            app.Run();


            
        }
    }
}