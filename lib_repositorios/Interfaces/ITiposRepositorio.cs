using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface ITiposRepositorio
    {
        List<Tipos> Listar();
        Tipos Guardar(Tipos entidad);
        Tipos Modificar(Tipos entidad);
        Tipos Borrar(Tipos entidad);
    }
}