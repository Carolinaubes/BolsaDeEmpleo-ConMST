using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Vacantes
    {
        [Key] public int id { get; set; } //Identificador de la vacante
        public int empresa_id { get; set; } //Identificador de Empresa
        public int cargo_id { get; set; } //Identificador de Cargo.
        public bool disponibilidad { get; set; } //Se refiere a la disponibilidad de la vacante, si está activa o no

        //Creacion de objetos
        [NotMapped] public Empresas? _Empresa { get; set; }//Objeto de empresa
        [NotMapped] public Cargos? _Cargo { get; set; } //Objeto de cargo

        //Metodos propios
        public void ActualizarDisponibilidad() //Metodo para actulizar el estado de la disponibilidad
        {

        }

        public void MostrarPostulaciones() //Metodo para mostrar todas las postulaciones
        {

        }
    }
}
