using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class CargosPruebaUnitaria
    {
        //Se declara un atributo de tipo ICargosRepositorio. Aunque no se pueden instanciar objetos de una interfaz, esta puede tomar la forma de una clase que la implemente
        private ICargosRepositorio? iRepositorio = null; 
        private Cargos? entidad = null;

        public CargosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-D1091LH\\DEV;database=BolsaDeEmpleo;Integrated Security=True;TrustServerCertificate=true;";
            //Se instancia un objeto de la clase CargosRepositorio, que implementa ICargosRepositorio, y se asigna a iRepositorio. Esto permite que iRepositorio use los métodos de la clase hija CargosRepositorio
            iRepositorio = new CargosRepositorio(conexion);
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
        private void Guardar() // Este metodo guarda una instancia de Cargos en la base de datos
        {
            entidad = new Cargos()
            {
                nombre = "Desarrollador",
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.id != 0);
        }
        private void Listar() //Este metodo lista la instancia Cargos en la base de datos
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
        public void Buscar() //Este metodo Busca un id especifico de la instancia Cargos en la base de datos
        {
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Modificar() //Cambia el cargo
        {
            entidad!.nombre = "Administrador";
            entidad = iRepositorio!.Modificar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.id ==
           entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Borrar() //Este metodo borra una instancia especifica
        {
            entidad = iRepositorio!.Borrar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.id ==
           entidad!.id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}
