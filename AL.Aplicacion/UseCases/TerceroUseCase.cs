using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public abstract class TerceroUseCase
{
    protected IRepositorioTercero Repositorio { get; private set; }

    public TerceroUseCase(IRepositorioTercero repositorio)
    {
        this.Repositorio = repositorio;
    }
}