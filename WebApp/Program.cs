using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopCore.Services;
using ShopCore.Services.IServices;
using ShopDataAccess;
using ShopDataAccess.Repository;
using ShopDataAccess.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext> (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IphoneListService, PhoneListService>();
builder.Services.AddScoped<IPhoneBookingService, PhoneBookingService>();
builder.Services.AddScoped<IPhoneListRepository, PhoneListRepository>();
builder.Services.AddScoped<IPhoneBookingRepository, PhoneBookingRepository>();
builder.Services.AddControllersWithViews();


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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
