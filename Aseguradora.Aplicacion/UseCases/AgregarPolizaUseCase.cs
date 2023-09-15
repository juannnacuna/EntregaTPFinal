using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UseCases;

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