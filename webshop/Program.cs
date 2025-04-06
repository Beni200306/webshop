using webshop.Data;
using webshop.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<WebshopDB>();
builder.Services.AddTransient<IRepository<Product>, ProductRepository>();



var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");



app.Run();
