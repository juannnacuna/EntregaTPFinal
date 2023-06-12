using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarVehiculoUseCase : VehiculoUseCase
{
    public AgregarVehiculoUseCase(IRepositorioVehiculo repo) : base(repo)
    {
    }
    public void Ejecutar(Vehiculo v)
    {
        Repositorio.AgregarVehiculo(v);
    }
}