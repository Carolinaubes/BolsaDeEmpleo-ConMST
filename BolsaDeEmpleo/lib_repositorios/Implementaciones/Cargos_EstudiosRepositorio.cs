using lib_repositorios.Interfaces;
using lib_entidades;
using lib_repositorios;
using System.Linq.Expressions;


public class Cargos_EstudiosRepositorio : ICargos_EstudiosRepositorio
{
    private Conexion? conexion = null; //Objeto de la clase conexion

    public Cargos_EstudiosRepositorio(Conexion conexion) //Inyeccion de dependencias
    {
        this.conexion = conexion;
    }
    public List<Cargos_Estudios> Listar()
    {
        return conexion!.Listar<Cargos_Estudios>();
    }

    public List<Cargos_Estudios> Buscar(Expression<Func<Cargos_Estudios, bool>> condiciones)
    {
        return conexion!.Buscar(condiciones);
    }

    public Cargos_Estudios Guardar(Cargos_Estudios entidad)
    {
        conexion!.Guardar(entidad);
        conexion!.GuardarCambios();
        return entidad;
    }

    public Cargos_Estudios Modificar(Cargos_Estudios entidad)
    {
        conexion!.Modificar(entidad);
        conexion!.GuardarCambios();
        return entidad;
    }

    public Cargos_Estudios Borrar(Cargos_Estudios entidad)
    {
        conexion!.Borrar(entidad);
        conexion!.GuardarCambios();
        return entidad;
    }
}