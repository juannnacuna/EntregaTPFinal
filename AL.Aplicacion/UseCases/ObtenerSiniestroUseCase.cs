using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerSiniestroUseCase : SiniestroUseCase
{
    public ObtenerSiniestroUseCase(IRepositorioSiniestro repo) : base(repo)
    {
    }
    public Siniestro? Ejecutar(int id)
    {
        return Repositorio.ObtenerSiniestro(id);
    }
}