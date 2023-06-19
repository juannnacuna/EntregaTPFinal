using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerPolizaUseCase : PolizaUseCase
{
    public ObtenerPolizaUseCase(IRepositorioPoliza repo) : base(repo)
    {
    }
    public Poliza? Ejecutar(int id)
    {
        return Repositorio.ObtenerPoliza(id);
    }
}