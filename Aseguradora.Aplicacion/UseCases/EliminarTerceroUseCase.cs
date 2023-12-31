using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UseCases;
public class EliminarTerceroUseCase : TerceroUseCase
{
    public EliminarTerceroUseCase(IRepositorioTercero repo) : base(repo)
    {
    }
    public void Ejecutar(int id)
    {
        Repositorio.EliminarTercero(id);
    }
}