namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

public class RepositorioVehiculo: IRepositorioVehiculo
{
    public void AgregarVehiculo(Vehiculo v)
    {
        using (var db = new Context())
        {
            var existeTitular = db.Titulares.Where(t => t.Id == v.TitularId).SingleOrDefault();
            if (existeTitular == null)
                throw new Exception($"No existe titular de Id {v.TitularId}");
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
            vModificar.Dominio = v.Dominio;
            vModificar.Marca = v.Marca;
            vModificar.Anio = v.Anio;
            vModificar.TitularId = v.TitularId;
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
    public Vehiculo? ObtenerVehiculo(int IdBuscado)
    {
       using (var db = new Context())
        {
            var vBuscado = db.Vehiculos.Where(v => v.Id == IdBuscado).SingleOrDefault();
            return vBuscado;
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
