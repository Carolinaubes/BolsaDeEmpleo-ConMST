using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class PersonasPruebaUnitaria
    {
        //Se declara un atributo de tipo IPersonasRepositorio. Aunque no se pueden instanciar objetos de una interfaz, esta puede tomar la forma de una clase que la implemente
        private IPersonasRepositorio? iRepositorio = null;
        private Personas? entidad = null;

        public PersonasPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-D1091LH\\DEV;database=BolsaDeEmpleo;Integrated Security=True;TrustServerCertificate=true;";
            //Se instancia un objeto de la clase PersonasRepositorio, que implementa IPersonasRepositorio, y se asigna a iRepositorio. Esto permite que iRepositorio use los métodos de la clase hija PersonasRepositorio
            iRepositorio = new PersonasRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Guardar();
            Listar();
            Buscar();
            Modificar();
            Borrar();
        }
        private void Guardar()
        {
            entidad = new Personas()
            {
                cedula = "1010",
                nombre = "Julian",
                direccion = "Calle 10"
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.id != 0);
        }
        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
        private void Buscar()
        {
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Modificar()
        {
            entidad!.direccion = "Calle 4";
            entidad = iRepositorio!.Modificar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}