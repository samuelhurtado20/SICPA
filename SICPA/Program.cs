using Microsoft.EntityFrameworkCore;
using SICPA.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<ApplicationDbContext>();
//builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(options =>
//        options.UseNpgsql("Host=localhost; Database=SICPA; Port=5432; Username=postgres; Password=159632;") //connection string
//        );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
