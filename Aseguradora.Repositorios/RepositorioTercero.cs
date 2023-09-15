namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public class RepositorioTercero: IRepositorioTercero
{
    public void AgregarTercero(Tercero t)
    {
        using (var db = new Context())
        {
            var existeSiniestro = db.Siniestros.Where(s => s.Id == t.SiniestroId).SingleOrDefault();
            if (existeSiniestro == null)
                throw new Exception($"No existe siniestro de Id {t.SiniestroId}");
            db.Add(t);
            db.SaveChanges();
        }
    }
    public void ModificarTercero(Tercero t)
    {
        using (var db = new Context())
        {
            var tModificar = db.Terceros.Where(x => x.Id == t.Id).SingleOrDefault();
            if (tModificar == null)
                throw new Exception($"No existe tercero de Id {t.Id}");
            tModificar.Apellido = t.Apellido;
            tModificar.Nombre = t.Nombre;
            tModificar.Dni = t.Dni;
            tModificar.Telefono = t.Telefono;
            tModificar.Aseguradora = t.Aseguradora;
            tModificar.SiniestroId = t.SiniestroId;
            db.SaveChanges();
        }
    }
    public void EliminarTercero(int IdBuscado)
    {
        using (var db = new Context())
        {
            var tEliminar = db.Terceros.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (tEliminar == null)
                throw new Exception($"No existe tercero de Id {IdBuscado}");
            db.Remove(tEliminar);
            db.SaveChanges();
        }
    }
    public Tercero? ObtenerTercero(int IdBuscado)
    {
       using (var db = new Context())
        {
            var tBuscado = db.Terceros.Where(t => t.Id == IdBuscado).SingleOrDefault();
            return tBuscado;
        } 
    }

    public List<Tercero> ListarTerceros()
    {
        using (var db = new Context())
        {
            var aux = db.Terceros.ToList();
            return aux;
        }
    }
}
