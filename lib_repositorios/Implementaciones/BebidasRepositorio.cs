using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class BebidasRepositorio : IBebidasRepositorio
    {
        private Conexion? conexion = null;

        public BebidasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Bebidas> Listar()
        {
            return conexion!.Listar<Bebidas>();
        }

        public Bebidas Guardar(Bebidas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Bebidas Modificar(Bebidas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Bebidas Borrar(Bebidas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}