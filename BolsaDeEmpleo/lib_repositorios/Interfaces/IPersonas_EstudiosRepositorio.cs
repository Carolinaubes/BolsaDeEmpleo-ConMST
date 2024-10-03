using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IPersonas_EstudiosRepositorio
    {
        //Metodos para la interfaz de Personas_Estudios
        public List<Personas_Estudios> Listar(); //Metodo que retorna una lista de las instancias en Personas_Estudios
        public List<Personas_Estudios> Buscar(Expression<Func<Personas_Estudios, bool>> condiciones); //Metodo que retorna una lista de Personas_Estudios que cumplan con una condicion
        public Personas_Estudios Guardar(Personas_Estudios entidad); //Metodo que guarda una instancia nueva de Personas_Estudios en la base de datos
        public Personas_Estudios Modificar(Personas_Estudios entidad); //Metodo que permite modificar atributos de una instancia de Personas_Estudios
        public Personas_Estudios Borrar(Personas_Estudios entidad); //Metodo que elimina/borra una instancia Personas_Estudios de la base de datos 
    }


}


