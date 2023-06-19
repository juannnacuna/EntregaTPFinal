namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public class RepositorioPoliza: IRepositorioPoliza
{
    public void AgregarPoliza(Poliza p)
    {
        using (var db = new Context())
        {
            var existeVehiculo = db.Vehiculos.Where(v => v.Id == p.VehiculoId).SingleOrDefault();
            if (existeVehiculo == null)
                throw new Exception($"No existe vehículo de Id {p.VehiculoId}");

            //comprobar que la poliza nueva no se superponga con una ya existente en ningúna fecha (para el mismo vehículo)
            List<Poliza>? todasPolizas = db.Polizas.Where(x => x.VehiculoId == p.VehiculoId).ToList();
            foreach(var polizaActual in todasPolizas)
            {
                if(!(polizaActual.FechaFinVigencia < p.FechaInicioVigencia || p.FechaFinVigencia < polizaActual.FechaInicioVigencia))
                    throw new Exception($"La póliza a agregar se superpone con una ya existente");
            }
            db.Add(p);
            db.SaveChanges();
        }
    }
    public void ModificarPoliza(Poliza p)
    {
        using (var db = new Context())
        {
            var pModificar = db.Polizas.Where(x => x.Id == p.Id).SingleOrDefault();
            if (pModificar == null)
            {
                throw new Exception($"No existe póliza de Id {p.Id}");
            }
            pModificar = p;
            db.SaveChanges();
        }
    }
    public void EliminarPoliza(int IdBuscado)
    {
        using (var db = new Context())
        {
            var pEliminar = db.Polizas.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (pEliminar == null)
                throw new Exception($"No existe póliza de Id {IdBuscado}");
            db.Remove(pEliminar);
            db.SaveChanges();
        }
    }
    public Poliza? ObtenerPoliza(int IdBuscado)
    {
       using (var db = new Context())
        {
            var pBuscado = db.Polizas.Where(p => p.Id == IdBuscado).SingleOrDefault();
            return pBuscado;
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
