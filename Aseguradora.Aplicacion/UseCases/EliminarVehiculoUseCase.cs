using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UseCases;
public class EliminarVehiculoUseCase : VehiculoUseCase
{
    public EliminarVehiculoUseCase(IRepositorioVehiculo repo) : base(repo)
    {
    }
    public void Ejecutar(int id)
    {
        Repositorio.EliminarVehiculo(id);
    }
}