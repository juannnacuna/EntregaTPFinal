using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListarPolizasUseCase : PolizaUseCase
{
    public ListarPolizasUseCase(IRepositorioPoliza repo) : base(repo)
    {
    }

    public List<Poliza> Ejecutar()
    {
        return Repositorio.ListarPolizas();
    }
}