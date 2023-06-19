using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarSiniestroUseCase : SiniestroUseCase
{
    public AgregarSiniestroUseCase(IRepositorioSiniestro repo) : base(repo)
    {
    }
    public void Ejecutar(Siniestro s)
    {
        Repositorio.AgregarSiniestro(s);
    }
}