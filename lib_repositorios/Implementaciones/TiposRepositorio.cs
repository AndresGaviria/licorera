using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class TiposRepositorio : ITiposRepositorio
    {
        private Conexion? conexion = null;

        public TiposRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Tipos> Listar()
        {
            return conexion!.Listar<Tipos>();
        }

        public Tipos Guardar(Tipos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos Modificar(Tipos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos Borrar(Tipos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}