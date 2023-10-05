using Microsoft.EntityFrameworkCore;
using xmlParserASP.Controllers;
using xmlParserASP.Entities;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;

//using MySQL.Data.EntityFrameworkCore.Extensions;

namespace xmlParserASP;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string connectionString =
            // "Server=DESKTOP-5KP5B17\\SQLEXPRESS;Database=MAX;Trusted_Connection=True;TrustServerCertificate=True"; // work desktop
            "Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;CharSet=utf8;"; // gamma max program DB


        string connectionStringTestGamma =
            "Database=zi391919_sandboxgamma;Data Source=zi391919.mysql.tools;User Id=zi391919_sandboxgamma;Password=!6km4kKY_9;"; // test gamma 

            string connectionStringGamma =
            "Database=zi391919_gamma;Data Source=zi391919.mysql.tools;User Id=zi391919_gamma;Password=6+0i4rZtS_;"; //gamma

        builder.Services.AddDbContext<MyDBContext>(options =>
            options.UseMySQL(connectionString));

        builder.Services.AddDbContext<TestGammaDBContext>(options =>
        options.UseMySQL(connectionStringTestGamma));

        //builder.Services.AddDbContext<>

        builder.Services.AddScoped<SupplierXmlSetting>();
        builder.Services.AddScoped<WriteToXL>();
        builder.Services.AddScoped<WriteRuToXL>();
        builder.Services.AddScoped<ReadAttrFromXmlTo3ColumnsRU>();
        builder.Services.AddScoped<ReadAttrFromXmlTo3ColumnsUA>();
        builder.Services.AddScoped<UniqNodesInXML>();
        builder.Services.AddScoped<ReadUniqueCategorys>();
        builder.Services.AddScoped<UpdatePriceQuantityService>();
        builder.Services.AddScoped<UpdatePriceQuantityController>();
        builder.Services.AddScoped<ProcessXMLController>();
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<PriceQuantityViewModel>();

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
        pattern: "{controller=UpdatePriceQuantity}/{action=Index}/{id?}");
//pattern: "{controller=Train}/{action=Index}/{id?}");




        ////var rUniq = serviceProvider.GetService<ReadUniqueCategorys>();
        ////rUniq.ReadXMLUniqueCategorys();

        ////UniqNodesInXML.Read();

        //// var model = serviceProvider.GetService<PathModel>();


        ////SQLQuery.ConnectToDB();




        app.Run();


            
    }
}