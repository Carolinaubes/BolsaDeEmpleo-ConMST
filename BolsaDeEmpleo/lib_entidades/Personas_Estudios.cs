using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
     public class Personas_Estudios
    {
        [Key] public int id { get; set; }  //Identificador de la relacion entre Personas y Estudios
        public int persona_id { get; set; } //Identificador de Personas
        public int estudio_id { get; set; } //Identificador de Estudios

        //Creacion de objetos
        [NotMapped] public Personas? _Persona { get; set; } //Objeto de personas
        [NotMapped] public Estudios? _Estudio { get; set; } //Objeto de Estudios
    }
}
