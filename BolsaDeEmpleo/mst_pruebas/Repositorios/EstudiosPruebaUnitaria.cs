using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class EstudiosPruebaUnitaria
    {
        //Se declara un atributo de tipo IEstudiosRepositorio. Aunque no se pueden instanciar objetos de una interfaz, esta puede tomar la forma de una clase que la implemente
        private IEstudiosRepositorio? iRepositorio = null;
        private Estudios? entidad = null;

        public EstudiosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-D1091LH\\DEV;database=BolsaDeEmpleo;Integrated Security=True;TrustServerCertificate=true;";
            //Se instancia un objeto de la clase EstudiosRepositorio, que implementa IEstudiosRepositorio, y se asigna a iRepositorio. Esto permite que iRepositorio use los métodos de la clase hija EstudiosRepositorio
            iRepositorio = new EstudiosRepositorio(conexion);
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
        private void Guardar() // Este metodo guarda una instancia de Estudios en la base de datos
        {
            entidad = new Estudios()
            {
                cod_estudio = 1,
                nombre = "Ingenieria"
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.id != 0);
        }
        private void Listar() //Este metodo lista la instancia Estudios en la base de datos
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
        private void Buscar() //Este metodo Busca un id especifico de la instancia Estudios en la base de datos
        {
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Modificar() //Cambia el nombre del estudio
        {
            entidad!.nombre = "Arquitectura";
            entidad = iRepositorio!.Modificar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Borrar() //Este metodo borra una instancia especifica
        {
            {
                entidad = iRepositorio!.Borrar(entidad!);
                var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
                Assert.IsTrue(lista.Count == 0);
            }
        }
    }
}
