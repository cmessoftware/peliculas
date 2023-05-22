using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using System.Text.Json.Serialization;
using Peliculas.Extensiones;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc().AddRazorRuntimeCompilation();
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();

//Configuracion del EF Core.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var AzureconnectionString = builder.Configuration.GetConnectionString("AzureConnection");

builder.Services.AddDbContext<PeliculasDbContext>(options =>
{
    options.UseSqlServer(connectionString, sqlServer =>
                         sqlServer.UseNetTopologySuite());

    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    //opciones.UseLazyLoadingProxies();
}
    );
builder.Services.AddControllers().AddJsonOptions(options =>
  options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//builder.Services.AddDbContext<PeliculasDbContext>(options =>
//                             options.UseInMemoryDatabase("Peliculas"));

builder.Services.AddServices();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


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

app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Generos}/{action=Index}/{id?}");

app.Run();
