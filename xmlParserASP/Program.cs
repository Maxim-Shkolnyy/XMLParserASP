using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Controllers;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Entities.Users;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;
using xmlParserASP.Services.UpdateServices;
using xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD;

namespace xmlParserASP;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddUserSecrets<Program>();
        
        builder.Services.AddDbContext<GammaContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("GammaConnection")));
        builder.Services.AddAntiforgery(options => { });

        builder.Services.AddAuthorization();
        builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme);
        builder.Services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<GammaContext>()
            .AddDefaultTokenProviders();

        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<MmSupplierXmlSetting>();
        builder.Services.AddScoped<WriteToXL>();
        builder.Services.AddScoped<WriteRuToXL>();
        builder.Services.AddScoped<ReadAttrFromXmlTo3ColumnsRU>();
        builder.Services.AddScoped<ReadAttrFromXmlTo3ColumnsUA>();
        builder.Services.AddScoped<UniqNodesInXML>();
        builder.Services.AddScoped<UpdatePriceQuantityService>();
        builder.Services.AddScoped<UpdatePriceQuantityController>();
        builder.Services.AddScoped<ProcessXMLController>();
        builder.Services.AddScoped<PriceQuantityViewModel>();
        builder.Services.AddScoped<UpdateMainXml>();
        builder.Services.AddSingleton<DataContainer>();
        builder.Services.AddSingleton<DataContainerSingleton>();
        builder.Services.AddTransient<DataCleaner>();
        builder.Services.AddTransient<DownloadPhotosResultModel>();
        builder.Services.AddTransient<DownloadPhotosService>();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();
 

        app.MapControllerRoute(
            name: "default",
        pattern: "{controller=UpdatePriceQuantity}/{action=Index}/{id?}");

        app.Run();
    }
}