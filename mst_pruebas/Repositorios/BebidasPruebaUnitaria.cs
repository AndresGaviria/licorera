using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class BebidasPruebaUnitaria
    {
        private IBebidasRepositorio? iRepositorio = null;
        
        public BebidasPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_licorera;uid=sa;pwd=...;TrustServerCertificate=true;";
            iRepositorio = new BebidasRepositorio(conexion);
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