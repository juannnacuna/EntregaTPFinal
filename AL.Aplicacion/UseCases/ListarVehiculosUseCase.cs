using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListarVehiculosUseCase : VehiculoUseCase
{
    public ListarVehiculosUseCase(IRepositorioVehiculo repo) : base(repo)
    {
    }
    public List<Vehiculo> Ejecutar()
    {
        return Repositorio.ListarVehiculos();
    }
}