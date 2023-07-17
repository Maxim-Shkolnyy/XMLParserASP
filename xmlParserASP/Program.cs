using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using xmlParserASP.Presistant;

//using MySQL.Data.EntityFrameworkCore.Extensions;

namespace xmlParserASP;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string connectionString =
            // "Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MAX;Trusted_Connection=True;TrustServerCertificate=True"; // work desktop
            "Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;"; // gamma max

        string connectionStringTestGamma =
            "Database=zi391919_sandboxgamma;Data Source=zi391919.mysql.tools;User Id=zi391919_sandboxgamma;Password=!6km4kKY_9;"; // gamma max


        builder.Services.AddDbContext<MyDBContext>(options =>
            options.UseMySQL(connectionString));

        builder.Services.AddDbContext<TestGammaDBContext>(options =>
        options.UseMySQL(connectionStringTestGamma));


        builder.Services.AddControllersWithViews();

        //builder.Services.AddSingleton<IWebHostEnvironment>(env => HostingEnvironment);

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
//pattern: "{controller=Train}/{action=Index}/{id?}");




        ////var rUniq = serviceProvider.GetService<ReadUniqueCategorys>();
        ////rUniq.ReadXMLUniqueCategorys();

        ////UniqNodesInXML.Read();

        //// var model = serviceProvider.GetService<PathModel>();


        ////SQLQuery.ConnectToDB();




        app.Run();


            
    }
}