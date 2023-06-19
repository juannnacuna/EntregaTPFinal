namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public class RepositorioSiniestro: IRepositorioSiniestro
{
    public void AgregarSiniestro(Siniestro s)
    {
        using (var db = new Context())
        {
            var p = db.Polizas.Where(p => p.Id == s.IdPoliza).SingleOrDefault(); 
            if (p == null) 
                throw new Exception($"No existe póliza de Id {s.IdPoliza}");
            if (!(p.FechaInicioVigencia < s.FechaOcurrencia && s.FechaOcurrencia < p.FechaFinVigencia))
                throw new Exception($"El siniestro sucedió fuera del periodo de vigencia de su póliza");                
            db.Add(s);
            db.SaveChanges();
        }
    }
    public void ModificarSiniestro(Siniestro s)
    {
        using (var db = new Context())
        {
            var sModificar = db.Siniestros.Where(x => x.Id == s.Id).SingleOrDefault();
            if (sModificar == null)
                throw new Exception($"No existe siniestro de Id {s.Id}");
            sModificar = s;
            db.SaveChanges();
        }
    }
    public void EliminarSiniestro(int IdBuscado)
    {
        using (var db = new Context())
        {
            var sEliminar = db.Siniestros.Where(s => s.Id == IdBuscado).SingleOrDefault();
            if (sEliminar == null)
                throw new Exception($"No existe siniestro de Id {IdBuscado}");
            db.Remove(sEliminar);
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
