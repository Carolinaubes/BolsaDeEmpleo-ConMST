using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class Personas_EstudiosPruebaUnitaria
    {
        //Se declara un atributo de tipo IPersonas_EstudiosRepositorio. Aunque no se pueden instanciar objetos de una interfaz, esta puede tomar la forma de una clase que la implemente
        private IPersonas_EstudiosRepositorio? iRepositorio = null;
        private Personas_Estudios? entidad = null;

        public Personas_EstudiosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=DESKTOP-D1091LH\\DEV;database=BolsaDeEmpleo;uid=sa;pwd=3312;TrustServerCertificate=true;";
            //Se instancia un objeto de la clase Personas_EstudiosRepositorio, que implementa IPersonas_EstudiosRepositorio, y se asigna a iRepositorio. Esto permite que iRepositorio use los métodos de la clase hija Personas_EstudiosRepositorio
            iRepositorio = new Personas_EstudiosRepositorio(conexion);
            
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
        private void Guardar() // Este metodo guarda una instancia de Personas_Estudios en la base de datos
        {
            entidad = new Personas_Estudios()
            {
                persona_id = 1,
                estudio_id = 1,
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.id != 0);
        }
        private void Listar() //Este metodo lista la instancia Personas_Estudios en la base de datos
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
        private void Buscar() //Este metodo Busca un id especifico de la instancia Personas_Estudios en la base de datos
        {
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Modificar() //Cambia el estudio de la persona
        {
            entidad!.estudio_id = 2;
            entidad = iRepositorio!.Modificar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Borrar() //Este metodo borra una instancia especifica
        {
            entidad = iRepositorio!.Borrar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.id == entidad!.id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}
