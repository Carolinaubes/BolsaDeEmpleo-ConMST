﻿using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class EmpresasRepositorio : IEmpresasRepositorio
    {
        private Conexion? conexion = null; //Objeto de la clase conexion

        public EmpresasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Empresas> Listar()
        {
            return conexion!.Listar<Empresas>();
        }

        public List<Empresas> Buscar(Expression<Func<Empresas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Empresas Guardar(Empresas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Empresas Modificar(Empresas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Empresas Borrar(Empresas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}