using Microsoft.EntityFrameworkCore;
using xmlParserASP.Controllers;
using xmlParserASP.Entities;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;

namespace xmlParserASP;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string connectionString = "Database=zi391919_maxim;Data Source=zi391919.mysql.tools;User Id=zi391919_maxim;Password=y5E~v52!Cv;CharSet=utf8;"; // gamma max program DB

        string connectionStringTestGamma = "Database=zi391919_sandboxgamma;Data Source=zi391919.mysql.tools;User Id=zi391919_sandboxgamma;Password=!6km4kKY_9;"; // test gamma 

        string connectionStringGamma = "Database=zi391919_gamma;Data Source=zi391919.mysql.tools;User Id=zi391919_gamma;Password=6+0i4rZtS_;"; //gamma

        builder.Services.AddDbContext<MyDBContext>(options => options.UseMySQL(connectionString));

        builder.Services.AddDbContext<TestGammaDBContext>(options => options.UseMySQL(connectionStringTestGamma));

        builder.Services.AddDbContext<GammaContext>(options => options.UseMySQL(connectionStringGamma));

        //builder.Services.AddDbContext<GammaContext>(options => options.UseMySQL(connectionStringGamma).LogTo(Console.WriteLine,
        //new[] { DbLoggerCategory.Database.Command.Name },
        //LogLevel.Information).EnableDetailedErrors());

        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<Mm_SupplierXmlSetting>();
        builder.Services.AddScoped<WriteToXL>();
        builder.Services.AddScoped<WriteRuToXL>();
        builder.Services.AddScoped<ReadAttrFromXmlTo3ColumnsRU>();
        builder.Services.AddScoped<ReadAttrFromXmlTo3ColumnsUA>();
        builder.Services.AddScoped<UniqNodesInXML>();
        builder.Services.AddScoped<ReadUniqueCategorys>();
        builder.Services.AddScoped<UpdatePriceQuantityService>();
        builder.Services.AddScoped<UpdatePriceQuantityController>();
        builder.Services.AddScoped<ProcessXMLController>();
        builder.Services.AddScoped<PriceQuantityViewModel>();
        builder.Services.AddScoped<UpdateMainXml>();

        //builder.Services.AddLogging(b => b.AddConsole());
        //builder.Services.AddSingleton<IWebHostEnvironment>(env => HostingEnvironment);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();
        //app.UseAuthentication();

        app.MapControllerRoute(
            name: "default",
        pattern: "{controller=UpdatePriceQuantity}/{action=Index}/{id?}");

        app.Run();
    }
}