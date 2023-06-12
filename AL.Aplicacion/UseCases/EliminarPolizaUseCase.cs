using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class EliminarPolizaUseCase : PolizaUseCase
{
    public EliminarPolizaUseCase(IRepositorioPoliza repo) : base(repo)
    {
    }
    public void Ejecutar(int id)
    {
        Repositorio.EliminarPoliza(id);
    }
}