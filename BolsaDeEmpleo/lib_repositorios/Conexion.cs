using lib_entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace lib_repositorios
{
    //
    public class Conexion : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected DbSet<Cargos>? Cargos { get; set; } //Representa una colección de instancias de tipo Cargos
        protected DbSet<Cargos_Estudios>? Cargos_Estudios { get; set; } //Representa una colección de instancias de tipo Cargos_Estudios
        protected DbSet<Empresas>? Empresas { get; set; } //Representa una colección de instancias de tipo Empresas 
        protected DbSet<Estudios>? Estudios { get; set; } //Representa una colección de instancias de tipo Estudios
        protected DbSet<Personas>? Personas { get; set; } //Representa una colección de instancias de tipo Personas
        protected DbSet<Personas_Estudios>? Personas_Estudios { get; set; } //Representa una colección de instancias de tipo Personas_Estudios
        protected DbSet<Postulaciones>? Postulaciones { get; set; } //Representa una colección de instancias de tipo Postulaciones
        protected DbSet<Vacantes>? Vacantes { get; set; } //Representa una colección de instancias de tipo Vacantes

        public virtual DbSet<T> ObtenerSet<T>() where T : class, new()
        {
            return this.Set<T>();
        }

        public virtual List<T> Listar<T>() where T : class, new()
        {
            return this.Set<T>().ToList();
        }

        public virtual List<T> Buscar<T>(Expression<Func<T, bool>> condiciones) where T : class, new()
        {
            return this.Set<T>().Where(condiciones).ToList();
        }

        public virtual bool Existe<T>(Expression<Func<T, bool>> condiciones) where T : class, new()
        {
            return this.Set<T>().Any(condiciones);
        }

        public virtual void Guardar<T>(T entidad) where T : class, new()
        {
            this.Set<T>().Add(entidad);
        }

        public virtual void Modificar<T>(T entidad) where T : class
        {
            var entry = this.Entry(entidad);
            entry.State = EntityState.Modified;
        }

        public virtual void Borrar<T>(T entidad) where T : class, new()
        {
            this.Set<T>().Remove(entidad);
        }

        public virtual void Separar<T>(T entidad) where T : class, new()
        {
            this.Entry(entidad).State = EntityState.Detached;
        }

        public virtual void GuardarCambios()
        {
            this.SaveChanges();
        }
    }
}
