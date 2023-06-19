using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
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