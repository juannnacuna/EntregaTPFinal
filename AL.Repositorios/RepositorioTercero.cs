namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public class RepositorioTercero: IRepositorioTercero
{
    public void AgregarTercero(Tercero t)
    {
        using (var db = new Context())
        {
            db.Add(t);
            db.SaveChanges();
        }
    }
    public void ModificarTercero(Tercero t)
    {
        using (var db = new Context())
        {
            var tModificar = db.Terceros.Where(x => x.Id == t.Id).SingleOrDefault();
            if (tModificar != null)
            {
                tModificar = t;
            }
            db.SaveChanges();
        }
    }
    public void EliminarTercero(int IdBuscado)
    {
        using (var db = new Context())
        {
            var tEliminar = db.Terceros.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (tEliminar != null)
            {
                db.Remove(tEliminar);
            }
            db.SaveChanges();
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
