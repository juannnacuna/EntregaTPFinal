using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarPolizaUseCase : PolizaUseCase
{
    public AgregarPolizaUseCase(IRepositorioPoliza repo) : base(repo)
    {
    }
    public void Ejecutar(Poliza p)
    {
        Repositorio.AgregarPoliza(p);
    }
}