using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using xmlParserASP.Controllers;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;
using xmlParserASP.Services.UpdateServices;

namespace xmlParserASP;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddUserSecrets<Program>();
        
        builder.Services.AddDbContext<GammaContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("GammaConnection")));
        builder.Services.AddAntiforgery(options => { });
        
        builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
        builder.Services.AddAuthorizationBuilder();

        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<MmSupplierXmlSetting>();
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
        builder.Services.AddSingleton<DataContainer>();
        builder.Services.AddSingleton<DataContainerSingleton>();
        builder.Services.AddTransient<DataCleaner>();
        
        var app = builder.Build();

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