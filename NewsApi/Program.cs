using Microsoft.EntityFrameworkCore;
using News.core;
using News.service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NewsContext>(options =>
   options.UseSqlServer(
      builder.Configuration.GetConnectionString("News")));

builder.Services.AddScoped<DbContext, NewsContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IRootService, RootService>();
builder.Services.AddHttpClient();   




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
