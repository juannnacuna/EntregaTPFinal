using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo v);
    void ModificarVehiculo(Vehiculo v);
    void EliminarVehiculo(int id);
    Vehiculo? ObtenerVehiculo(int id);
    List<Vehiculo> ListarVehiculos();
}
