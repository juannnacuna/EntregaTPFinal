namespace AL.Repositorios;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public class RepositorioVehiculo: IRepositorioVehiculo
{
    public void AgregarVehiculo(Vehiculo v)
    {
        using (var db = new Context())
        {
            db.Add(v);
            db.SaveChanges();
        }
    }
    public void ModificarVehiculo(Vehiculo v)
    {
        using (var db = new Context())
        {
            var vModificar = db.Vehiculos.Where(x => x.Id == v.Id).SingleOrDefault();
            if (vModificar == null)
                throw new Exception($"No existe vehículo de Id {v.Id}");
            vModificar = v;
            db.SaveChanges();
        }
    }
    public void EliminarVehiculo(int IdBuscado)
    {
        using (var db = new Context())
        {
            var vEliminar = db.Vehiculos.Where(t => t.Id == IdBuscado).SingleOrDefault();
            if (vEliminar == null)
                throw new Exception($"No existe vehículo de Id {IdBuscado}");
            db.Remove(vEliminar);
            db.SaveChanges();
        }
    }

    public List<Vehiculo> ListarVehiculos()
    {
        using (var db = new Context())
        {
            var aux = db.Vehiculos.ToList();
            return aux;
        }
    }
}
