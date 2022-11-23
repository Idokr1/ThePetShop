using ThePetShop.Data;
using Microsoft.EntityFrameworkCore;
using ThePetShop.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IPetRepository, PetRepository>();
string connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<PetContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<PetContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}");
});

app.Run();
