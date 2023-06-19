namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;

public class RepositorioTitular : IRepositorioTitular
{
    public void AgregarTitular(Titular t)
    {
        using (var db = new Context())
        {
            db.Add(t);
            db.SaveChanges();
        }
    }
    public void ModificarTitular(Titular t)
    {
        using (var db = new Context())
        {
            var tModificar = db.Titulares.Where(x => x.Dni == t.Dni).SingleOrDefault();
            if (tModificar == null)
                throw new Exception($"No existe titular de Dni {t.Dni}");
            tModificar = t;
            db.SaveChanges();
        }
    }
    public void EliminarTitular(int IdBuscado)
    {
        using (var db = new Context())
        {
            var tEliminar = db.Titulares.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (tEliminar == null)
                throw new Exception($"No existe titular de Id {IdBuscado}");
            db.Remove(tEliminar);
            db.SaveChanges();
        }
    }
    public List<Titular> ListarTitulares()
    {
        using (var db = new Context())
        {
            var aux = db.Titulares.ToList();
            return aux;
        }
    }
    public List<Titular> ListarTitularesConSusVehiculos()
    {
        using (var db = new Context())
        {
            var aux = db.Titulares.Include(t => t.Vehiculos).ToList();
            return aux;
        }
    }
}
