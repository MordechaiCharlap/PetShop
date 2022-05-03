using PetShop.Data.Contexts;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using PetShop.Data.Repositories.Interfaces;
using PetShop.Data.Repositories;
using PetShop.Service.Interfaces;
using PetShop.Service;

var builder = WebApplication.CreateBuilder(args);

// Add servic        es to the container.
builder.Services.AddDbContext<PetShopDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PetShopDataConnection")));
//builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
//builder.Services.AddScoped<IAnimalService, AnimalService>();
builder.Services.AddControllersWithViews();


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
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
