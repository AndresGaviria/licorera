using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class TiposPruebaUnitaria
    {
        private ITiposRepositorio? iRepositorio = null;
        
        public TiposPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_licorera;uid=sa;pwd=...;TrustServerCertificate=true;";
            iRepositorio = new TiposRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Listar();
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
    }
}