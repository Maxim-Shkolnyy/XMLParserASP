using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

        builder.Configuration.AddUserSecrets<Program>();

        //builder.Services.AddDbContext<MyDBContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("myDbConnectionString")));
        //builder.Services.AddDbContext<TestGammaDBContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("connectionStringTestGamma")));

        builder.Services.AddDbContext<GammaContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("GammaConnection")));
        //builder.Services.AddDatabaseDeveloperPageExceptionFilter();
        //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
        //        .AddEntityFrameworkStores<GammaContext>();
        builder.Services.AddAntiforgery(options => { });
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
        app.UseAuthentication();

        app.MapControllerRoute(
            name: "default",
        pattern: "{controller=UpdatePriceQuantity}/{action=Index}/{id?}");

        app.Run();
    }
}