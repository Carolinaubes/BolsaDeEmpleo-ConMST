using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Cargos_Estudios
    {
        [Key] public int id { get; set; } // //Identificador de la relacion entre Cargos y Estudios
        public int cargo_id { get; set; } //Identificador de Cargos
        public int estudio_id {  get; set; } //Identificador de Estudio

        //Creacion de objetos
        [NotMapped] public Cargos? _Cargo { get; set; } //Objeto de Cargos
        [NotMapped] public Estudios? _Estudio { get; set; } //Objeto de Estudios
    }
}
