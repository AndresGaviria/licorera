using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IBebidasRepositorio
    {
        List<Bebidas> Listar();
        Bebidas Guardar(Bebidas entidad);
        Bebidas Modificar(Bebidas entidad);
        Bebidas Borrar(Bebidas entidad);
    }
}