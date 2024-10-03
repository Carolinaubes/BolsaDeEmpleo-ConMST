using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IPostulacionesRepositorio
    {
        //Métodos para la interfaz de postulaciones
        public List<Postulaciones> Listar(); //Metodo que retorna una lista de las instancias en Postulaciones
        public List<Postulaciones> Buscar(Expression<Func<Postulaciones, bool>> condiciones); //Metodo que retorna una lista de Postulaciones que cumplan con una condicion
        public Postulaciones Guardar(Postulaciones entidad); //Metodo que guarda una instancia nueva de Postulaciones en la base de datos
        public Postulaciones Modificar(Postulaciones entidad); //Metodo que permite modificar atributos de una instancia de Postulaciones
        public Postulaciones Borrar(Postulaciones entidad); //Metodo que elimina/borra una instancia Postulaciones de la base de datos  
    }
}
