using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public abstract class PolizaUseCase
{
    protected IRepositorioPoliza Repositorio { get; private set; }

    public PolizaUseCase(IRepositorioPoliza repositorio)
    {
        this.Repositorio = repositorio;
    }
}