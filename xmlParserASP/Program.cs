using System;
using System.Configuration;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore.Extensions;

using XMLparser.Presistant;

namespace xmlParserASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

             //var connectionString= "Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MAX;Trusted_Connection=True;TrustServerCertificate=True" // work desktop

             var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<MyDBContext>(options => options.UseMySql( serverVersion));
            builder.Services.AddDbContext<MyDBContext>(options =>
                options.UseMySql("Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;", serverVersion));
            //builder.Services.AddDbContextPool<MyDBContext>(options =>
            //{
            //    var connetionString = Configuration.GetConnectionString("DefaultConnection");
            //    options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
            //});

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

            app.Run();
        }
    }
}