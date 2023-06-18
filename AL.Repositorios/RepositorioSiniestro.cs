namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public class RepositorioSiniestro: IRepositorioSiniestro
{
    public void AgregarSiniestro(Siniestro s)
    {
        using (var db = new Context())
        {
            //if()
            //{
                db.Add(s);
                db.SaveChanges();
            //}
        }
    }
    public void ModificarSiniestro(Siniestro s)
    {
        using (var db = new Context())
        {
            var sModificar = db.Siniestros.Where(x => x.Id == s.Id).SingleOrDefault();
            if (sModificar != null)
            {
                sModificar = s;
            }
            db.SaveChanges();
        }
    }
    public void EliminarSiniestro(int IdBuscado)
    {
        using (var db = new Context())
        {
            var sEliminar = db.Siniestros.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (sEliminar != null)
            {
                db.Remove(sEliminar);
            }
            db.SaveChanges();
        }
    }

    public List<Siniestro> ListarSiniestros()
    {
        using (var db = new Context())
        {
            var aux = db.Siniestros.ToList();
            return aux;
        }
    }
}
