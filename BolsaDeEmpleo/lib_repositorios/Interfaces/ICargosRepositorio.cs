using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ICargosRepositorio
    {
        //Métodos para la interfaz de Cargos
        public List<Cargos> Listar(); //Metodo que retorna una lista de las instancias en Cargos
        public List<Cargos> Buscar(Expression<Func<Cargos, bool>> condiciones); //Metodo que retorna una lista de Cargos que cumplan con una condicion
        public Cargos Guardar(Cargos entidad); //Metodo que guarda una instancia nueva de Cargos en la base de datos
        public Cargos Modificar(Cargos entidad); //Metodo que permite modificar atributos de una instancia de Cargos
        public Cargos Borrar(Cargos entidad); //Metodo que elimina/borra una instancia Cargos de la base de datos 
    }
}
