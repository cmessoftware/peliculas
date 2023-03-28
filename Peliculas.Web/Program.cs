using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using System.Text.Json.Serialization;
using Peliculas.Servicios.Peliculas;
using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.Servicios.Comentarios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Configuracion del EF Core.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var AzureconnectionString = builder.Configuration.GetConnectionString ( "AzureConnection" );

builder.Services.AddDbContext<PeliculasDbContext>(options =>
{
    options.UseSqlServer(AzureconnectionString, sqlServer => sqlServer.UseNetTopologySuite());
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    //opciones.UseLazyLoadingProxies();
}
    );
builder.Services.AddControllers().AddJsonOptions(options =>
  options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//builder.Services.AddDbContext<PeliculasDbContext>(options =>
//                             options.UseInMemoryDatabase("Peliculas"));


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IServicioPelicula, ServicioPeliculaDB>();
builder.Services.AddScoped<IServicioComentarios, ServicioComentarioBD>();
builder.Services.AddScoped<IRepositorioPeliculas, RepositorioPeliculas>();
builder.Services.AddScoped<IRepositorioComentarios, RepositorioComentarios>();

builder.Services.AddAutoMapper ( AppDomain.CurrentDomain.GetAssemblies () );


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
    pattern: "{controller=Peliculas}/{action=Index}/{id?}");

app.Run();
