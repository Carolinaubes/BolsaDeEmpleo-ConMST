using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{   
    
    public interface IEstudiosRepositorio
    {
        //Metodos para la interfaz de Estudios
        public List<Estudios> Listar(); //Metodo que retorna una lista de Estudios que cumplan con una condicion
        public List<Estudios> Buscar(Expression<Func<Estudios, bool>> condiciones); //Metodo que retorna una lista de Estudios que cumplan con una condicion
        public Estudios Guardar(Estudios entidad); //Metodo que guarda una instancia nueva de Estudios en la base de datos
        public Estudios Modificar(Estudios entidad); //Metodo que permite modificar atributos de una instancia de Estudios
        public Estudios Borrar(Estudios entidad); //Metodo que elimina/borra una instancia Estudios de la base de datos 
    }
}
