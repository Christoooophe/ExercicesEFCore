using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExercicesEFCore.Data;
using ExercicesEFCore.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ExercicesEFCoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ExercicesEFCoreContext") ?? throw new InvalidOperationException("Connection string 'ExercicesEFCoreContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();//Cache
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
}
);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession(); //Active la session

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ToDo}/{action=Index}/{id?}");

app.Run();
