using Microsoft.EntityFrameworkCore;
using Mission_11_jefferson_lambert.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<DBBookContext>(options =>
{
    Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<DBBookContext> optionsBuilder = (Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<DBBookContext>)options;
    optionsBuilder.UseSqlite(builder.Configuration["ConnectionStrings:BookConnection"]);
});

builder.Services.AddScoped<IBookRepo, EFBookRepo>();

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

app.MapControllerRoute("pagination", "Books/{pageNum}", new { Controller = "Home", action = "Index" });
app.MapDefaultControllerRoute();
app.Run();
