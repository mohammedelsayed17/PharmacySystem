using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PharmacySystem.Data;
using PharmacySystem.Models;
using PharmacySystem.Services;

var builder = WebApplication.CreateBuilder(args);

// For demonstration only – not actively used
builder.Services.AddScoped<IMedicineRepository, MedicineRepository>();
builder.Services.AddScoped<INotificationService, NotificationService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure EF Core with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

// Repositories and services (DI)
builder.Services.AddScoped<IMedicineRepository, MedicineRepository>();

// Cookies
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
});

var app = builder.Build();

// Seed admin emails
//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    SeedAdmin.Seed(services).Wait();
//}

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
