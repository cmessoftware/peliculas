using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using Peliculas.Repositorio;
using Peliculas.Servicios;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddLogging(config =>
{
    config.AddDebug();
    config.AddConsole();
    //etc
});
//Configuracion del EF Core.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PeliculasDbContext>(options =>
{
    options.UseSqlServer(connectionString, sqlServer => sqlServer.UseNetTopologySuite());
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    //opciones.UseLazyLoadingProxies();
}
    );
builder.Services.AddControllers().AddJsonOptions(opciones =>
  opciones.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//builder.Services.AddDbContext<PeliculasDbContext>(options =>
//                             options.UseInMemoryDatabase("Peliculas"));

builder.Services.AddScoped<IServicioPelicula, ServicioPeliculaMemoria>();
builder.Services.AddScoped<IRepositorioPeliculas, RepositorioPeliculas>();

//var logger = new LoggerConfiguration()
//                .ReadFrom.Configuration(builder.Configuration)
//                .Enrich.FromLogContext()
//                .CreateLogger();

//builder.Logging.ClearProviders();
//builder.Logging.AddSerilog(logger);

////create the logger and setup your sinks, filters and properties
//Log.Logger = new LoggerConfiguration()
//    .WriteTo.Console()
//    .CreateLogger();

//Log.Logger = new LoggerConfiguration()
//    .WriteTo.Console()
//    .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
//    .CreateLogger();
//.WriteTo.File("log.txt",
//  outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


builder.Services.AddControllers();



//Fin configuracion EF Core.

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Peliculas}/{action=Index}/{id?}");

app.Run();
