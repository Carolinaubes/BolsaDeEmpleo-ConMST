using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IEmpresasRepositorio
    {
        //Métodos para la interfaz de Empresas
        public List<Empresas> Listar(); //Metodo que retorna una lista de las instancias en Empresas
        public List<Empresas> Buscar(Expression<Func<Empresas, bool>> condiciones); //Metodo que retorna una lista de Empresas que cumplan con una condicion
        public Empresas Guardar(Empresas entidad); //Metodo que guarda una instancia nueva de Empresas en la base de datos
        public Empresas Modificar(Empresas entidad); //Metodo que permite modificar atributos de una instancia de Empresas
        public Empresas Borrar(Empresas entidad);  //Metodo que elimina/borra una instancia Empresas de la base de datos 
    }
}
