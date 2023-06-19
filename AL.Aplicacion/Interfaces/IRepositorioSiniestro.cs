using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioSiniestro
{
    void AgregarSiniestro(Siniestro s);
    void ModificarSiniestro(Siniestro s);
    void EliminarSiniestro(int id);
    Siniestro? ObtenerSiniestro(int id);
    List<Siniestro> ListarSiniestros();
}
