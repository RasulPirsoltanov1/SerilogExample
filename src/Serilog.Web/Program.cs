using Microsoft.AspNetCore.Identity;
using SerilogExample.DataAccess;
using SerilogExample.DataAccess.Context;
using SerilogExample.Core.Entities;
using SerilogExample.Business;
using Serilog.Events;
using System.Globalization;
using Serilog.Sinks.SystemConsole.Themes;
using Serilog.Core;
using Serilog.Sinks.MSSqlServer;
using Serilog;
using Serilog.Business;
//using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Configuration.AddJsonFile("appsettings.json", false).AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true);


builder.Services.AddDataAccess(builder.Configuration);

#region SerilogConfigs
try
{
    // Logger konfigurasiyasını yarat
    Logger loggerConfiguration = new LoggerConfiguration()
      .ReadFrom.Configuration(new ConfigurationBuilder()
        .AddJsonFile("appsettings.serilog-configs.json")
        .Build()).WriteTo.Console(
           restrictedToMinimumLevel: LogEventLevel.Warning,
           outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}",
           syncRoot: true,
           applyThemeToRedirectedOutput: true,
           formatProvider: new CultureInfo("en"),
           theme: SystemConsoleTheme.Colored)
        .WriteTo.File($"{Directory.GetCurrentDirectory()}/logs.txt")
       // loglari Db yə yazmaq ucun "Serilog.Sinks.MSSqlServer" paketini yuklemek lazimdir
       .WriteTo.MSSqlServer(
        connectionString: "Data Source=DESKTOP-NG2G057;Initial Catalog=SerilogExampleDB;Integrated Security=True ;TrustServerCertificate=True",
        sinkOptions: new MSSqlServerSinkOptions
        {
            BatchPeriod = TimeSpan.FromSeconds(5),
            BatchPostingLimit = 100,
            TableName = "SerilogTable",
            AutoCreateSqlTable = true,
            SchemaName = "dbo"
        },
        restrictedToMinimumLevel: LogEventLevel.Warning
        )
      .Enrich.FromLogContext()
      .CreateLogger();


    // Mövcud loglama providerlerini təmizləyirik
    builder.Logging.ClearProviders();

    // Serilog'u loglama provideri kimi əlavə et
    builder.Logging.AddSerilog(loggerConfiguration);
}
catch (Exception ex)
{
    Console.WriteLine($"Message : {ex.Message}");
    throw new Exception(ex.Message,ex.InnerException);
}
#endregion







//Identity
builder.Services.AddIdentity<AppUser, AppRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

    options.LoginPath = "/Auth/Login";
    options.AccessDeniedPath = "/Auth/Login";
    options.SlidingExpiration = true;
});

//business configurations
await builder.Services.AddStartupConfigurationsAsync();
builder.Services.AddBusiness();


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

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
