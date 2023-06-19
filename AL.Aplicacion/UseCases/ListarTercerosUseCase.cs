using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListarTercerosUseCase : TerceroUseCase
{
    public ListarTercerosUseCase(IRepositorioTercero repo) : base(repo)
    {
    }
    public List<Tercero> Ejecutar()
    {
        return Repositorio.ListarTerceros();
    }
}