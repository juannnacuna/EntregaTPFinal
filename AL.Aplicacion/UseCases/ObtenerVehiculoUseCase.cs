using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerVehiculoUseCase : VehiculoUseCase
{
    public ObtenerVehiculoUseCase(IRepositorioVehiculo repo) : base(repo)
    {
    }
    public Vehiculo? Ejecutar(int id)
    {
        return Repositorio.ObtenerVehiculo(id);
    }
}