namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public class RepositorioPoliza: IRepositorioPoliza
{
    public void AgregarPoliza(Poliza p)
    {
        using (var db = new Context())
        {
            db.Add(p);
            db.SaveChanges();
        }
    }
    public void ModificarPoliza(Poliza p)
    {
        using (var db = new Context())
        {
            var pModificar = db.Polizas.Where(x => x.Id == p.Id).SingleOrDefault();
            if (pModificar != null)
            {
                pModificar = p;
            }
            db.SaveChanges();
        }
    }
    public void EliminarPoliza(int IdBuscado)
    {
        using (var db = new Context())
        {
            var pEliminar = db.Polizas.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (pEliminar != null)
            {
                db.Remove(pEliminar);
            }
            db.SaveChanges();
        }
    }

    public List<Poliza> ListarPolizas()
    {
        using (var db = new Context())
        {
            var aux = db.Polizas.ToList();
            return aux;
        }
    }
}
