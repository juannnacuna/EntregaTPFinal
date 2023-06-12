using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public abstract class SiniestroUseCase
{
    protected IRepositorioSiniestro Repositorio { get; private set; }

    public SiniestroUseCase(IRepositorioSiniestro repositorio)
    {
        this.Repositorio = repositorio;
    }
}