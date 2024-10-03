using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ICargos_EstudiosRepositorio
    {
        //Métodos para la interfaz de Cargos_Estudios
        public List<Cargos_Estudios> Listar(); //Metodo que retorna una lista de las instancias en Cargos_Estudios
        public List<Cargos_Estudios> Buscar(Expression<Func<Cargos_Estudios, bool>>condiciones); //Metodo que retorna una lista de Cargos_Estudios que cumplan con una condicion
        public Cargos_Estudios Guardar(Cargos_Estudios entidad); //Metodo que guarda una instancia nueva de Cargos_Estudios en la base de datos
        public Cargos_Estudios Modificar(Cargos_Estudios entidad); //Metodo que permite modificar atributos de una instancia de Cargos_Estudios
        public Cargos_Estudios Borrar(Cargos_Estudios entidad); //Metodo que elimina/borra una instancia Cargos_Estudios de la base de datos 
    }
}
