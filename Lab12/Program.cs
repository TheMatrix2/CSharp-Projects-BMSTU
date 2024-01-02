using Lab12.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo;
using Lab12.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContextPool<LibraryContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DatabaseConnectionString"),
        new MySqlServerVersion(new Version(8, 0, 25))));

builder.Services.AddTransient<Lab12.Services.ICollection<Author>, SqlAuthors>();
builder.Services.AddTransient<Lab12.Services.ICollection<Publisher>, SqlPublishers>();
builder.Services.AddTransient<Lab12.Services.ICollection<Book>, SqlBooks>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapRazorPages();  // Добавляем маршрутизацию для Razor Pages
// });

app.Run();