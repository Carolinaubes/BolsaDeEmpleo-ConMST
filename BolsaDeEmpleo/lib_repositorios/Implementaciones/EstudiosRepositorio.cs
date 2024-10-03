using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class EstudiosRepositorio : IEstudiosRepositorio
    {
        private Conexion? conexion = null; //Objeto de la clase conexion

        public EstudiosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Estudios> Listar()
        {
            return conexion!.Listar<Estudios>();
        }

        public List<Estudios> Buscar(Expression<Func<Estudios, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Estudios Guardar(Estudios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Estudios Modificar(Estudios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Estudios Borrar(Estudios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}