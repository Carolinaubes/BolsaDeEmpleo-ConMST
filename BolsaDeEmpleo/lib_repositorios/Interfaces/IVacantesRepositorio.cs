using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IVacantesRepositorio
    {
        //Métodos para la interfaz de vacantes
        public List<Vacantes> Listar(); //Metodo que retorna una lista de las instancias en Vacantes
        public List<Vacantes> Buscar(Expression<Func<Vacantes, bool>> condiciones); //Metodo que retorna una lista de Vacantes que cumplan con una condicion
        public Vacantes Guardar(Vacantes entidad); //Metodo que guarda una instancia nueva de Vacantes en la base de datos
        public Vacantes Modificar(Vacantes entidad); //Metodo que permite modificar atributos de una instancia de Vacantes
        public Vacantes Borrar(Vacantes entidad); //Metodo que elimina/borra una instancia Vacantes de la base de datos 
    }
}
