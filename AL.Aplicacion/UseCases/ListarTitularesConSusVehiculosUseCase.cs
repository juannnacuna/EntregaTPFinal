using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class ListarTitularesConSusVehiculosUseCase : TitularUseCase
{
    public ListarTitularesConSusVehiculosUseCase(IRepositorioTitular repo) : base(repo)
    {
    }
    public List<Titular> Ejecutar()
    {
        return Repositorio.ListarTitularesConSusVehiculos();
    }
}