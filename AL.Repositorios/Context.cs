using AL.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AL.Repositorios;

public class Context : DbContext
{
    #nullable disable
    public DbSet<Vehiculo> Vehiculos { get; set; }
    public DbSet<Titular> Titulares  { get; set; }
    public DbSet<Tercero> Terceros { get; set; }
    public DbSet<Siniestro> Siniestros { get; set; }
    public DbSet<Poliza> Polizas { get; set; }
    #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}