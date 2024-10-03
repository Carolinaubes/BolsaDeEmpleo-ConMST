using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IPersonasRepositorio
    {
        //Metodos para la interfaz de Personas
        public List<Personas> Listar(); //Metodo que retorna una lista de las instancias en Personas
        public List<Personas> Buscar(Expression<Func<Personas, bool>> condiciones); //Metodo que retorna una lista de Personas que cumplan con una condicion
        public Personas Guardar(Personas entidad); //Metodo que guarda una instancia nueva de Personas en la base de datos
        public Personas Modificar(Personas entidad); //Metodo que permite modificar atributos de una instancia de Personas
        public Personas Borrar(Personas entidad); //Metodo que elimina/borra una instancia Personas de la base de datos 
    }
}
