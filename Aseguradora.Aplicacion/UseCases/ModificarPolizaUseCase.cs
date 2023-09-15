using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UseCases;

public class ModificarPolizaUseCase : PolizaUseCase
{
    public ModificarPolizaUseCase(IRepositorioPoliza repo) : base(repo)
    {
    }
    public void Ejecutar(Poliza p)
    {
        Repositorio.ModificarPoliza(p);
    }
}