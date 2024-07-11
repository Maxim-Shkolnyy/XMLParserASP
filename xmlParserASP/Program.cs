using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using xmlParserASP.Controllers;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Entities.Users;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;
using xmlParserASP.Services.UpdateServices;
using xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD;
using System.Text;
using xmlParserASP.Models.ViewModels;
using Microsoft.Data.SqlClient;

namespace xmlParserASP;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddUserSecrets<Program>();

        builder.Services.AddDbContext<GammaContext>(options =>
            options.UseMySQL(builder.Configuration.GetConnectionString("GammaConnection")));
        builder.Services.AddDbContext<AppHostingContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("AppHostingConnection")));

        builder.Services.AddAntiforgery(options => { });

        builder.Services.AddIdentity<User, IdentityRole>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;
        })
        .AddEntityFrameworkStores<AppHostingContext>()
        .AddDefaultTokenProviders();

        builder.Services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;

            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

            options.User.AllowedUserNameCharacters =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._";
            options.User.RequireUniqueEmail = false;
        });

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(60); 

            options.LoginPath = "/Identity/Account/Login";
            options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            options.SlidingExpiration = true;
            
            // options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Обязательно использовать защищенные куки
            // options.Cookie.SameSite = SameSiteMode.Strict; // Конфигурация политики SameSite
        });

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
            pattern: "{controller=Account}/{action=Login}/{id?}");

        app.Run();
    }
}