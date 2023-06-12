using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public abstract class TitularUseCase
{
    protected IRepositorioTitular Repositorio { get; private set; }

    public TitularUseCase(IRepositorioTitular repositorio)
    {
        this.Repositorio = repositorio;
    }
}