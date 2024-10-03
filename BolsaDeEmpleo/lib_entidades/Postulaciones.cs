using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace lib_entidades
{
    public class Postulaciones
    {
        [Key] public int id { get; set; } //Identificador de la postulaciones
        public int vacante_id { get; set; } //Identificador de la vacante
        public int persona_id { get; set; } //Identificador de persona
        public bool elegido {  get; set; } //Indica si la persona fue seleccionada o no

        //Creacion de objetos
        [NotMapped] public Vacantes? _Vacantes { get; set; } //Objeto de vacantes
        [NotMapped] public Personas? _Personas { get; set; } //Objeto de personas

        //Metodos propios
        public void ActualizarElegido() //Metodo para actualizar el estado de eleccion de una persona dentro de una postulacion
        {

        }
    }
}
