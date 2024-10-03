using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Personas
    {
        [Key] public int id { get; set; }  //Identificador de persona
        public string? cedula { get; set; } //Corresponde a la cedula de la persona
        public string? nombre { get; set; } //Se refiere al nombre de la persona
        public string? direccion { get; set; } //Direccion de la persona

        //Metodos propios
        public void ActualizarDireccion() //Metodo para actualizar la direccion de la persona
        {

        }
    }
}
