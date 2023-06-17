namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;

public class RepositorioTitularTXT : IRepositorioTitular
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
            var tModificar = db.Titulares.Where(x => x.Id == t.Id).SingleOrDefault();
            if (tModificar != null)
            {
                tModificar = t;
            }
            db.SaveChanges();
        }
    }
    public void EliminarTitular(int IdBuscado)
    {
        using (var db = new Context())
        {
            var tEliminar = db.Titulares.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (tEliminar != null)
            {
                foreach (var vEliminar in db.Vehiculos.Where(v => v.IdTitular == IdBuscado))
                {
                    db.Remove(vEliminar);
                }
                db.Remove(tEliminar);
            }
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
