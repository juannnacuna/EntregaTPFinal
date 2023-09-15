using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Aseguradora.Repositorios;
using Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddTransient<AgregarPolizaUseCase>();
builder.Services.AddTransient<AgregarSiniestroUseCase>();
builder.Services.AddTransient<AgregarTerceroUseCase>();
builder.Services.AddTransient<AgregarTitularUseCase>();
builder.Services.AddTransient<AgregarVehiculoUseCase>();
builder.Services.AddTransient<EliminarPolizaUseCase>();
builder.Services.AddTransient<EliminarSiniestroUseCase>();
builder.Services.AddTransient<EliminarTerceroUseCase>();
builder.Services.AddTransient<EliminarTitularUseCase>();
builder.Services.AddTransient<EliminarVehiculoUseCase>();
builder.Services.AddTransient<ListarPolizasUseCase>();
builder.Services.AddTransient<ListarSiniestrosUseCase>();
builder.Services.AddTransient<ListarTercerosUseCase>();
builder.Services.AddTransient<ListarTitularesUseCase>();
builder.Services.AddTransient<ListarTitularesConSusVehiculosUseCase>();
builder.Services.AddTransient<ListarVehiculosUseCase>();
builder.Services.AddTransient<ModificarPolizaUseCase>();
builder.Services.AddTransient<ModificarSiniestroUseCase>();
builder.Services.AddTransient<ModificarTerceroUseCase>();
builder.Services.AddTransient<ModificarTitularUseCase>();
builder.Services.AddTransient<ModificarVehiculoUseCase>();
builder.Services.AddTransient<ObtenerPolizaUseCase>();
builder.Services.AddTransient<ObtenerSiniestroUseCase>();
builder.Services.AddTransient<ObtenerTerceroUseCase>();
builder.Services.AddTransient<ObtenerTitularUseCase>();
builder.Services.AddTransient<ObtenerVehiculoUseCase>();
builder.Services.AddScoped<IRepositorioPoliza, RepositorioPoliza>();
builder.Services.AddScoped<IRepositorioSiniestro, RepositorioSiniestro>();
builder.Services.AddScoped<IRepositorioTercero, RepositorioTercero>();
builder.Services.AddScoped<IRepositorioTitular, RepositorioTitular>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();

using (var context = new Context())
{
    context.Database.EnsureCreated();
    var connection = context.Database.GetDbConnection();
    connection.Open();
    using (var command = connection.CreateCommand())
    {
        command.CommandText = "PRAGMA journal_mode=DELETE;";
        command.ExecuteNonQuery();
    }
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
