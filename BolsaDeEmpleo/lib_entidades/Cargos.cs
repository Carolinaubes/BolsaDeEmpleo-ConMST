using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Cargos
    {
        [Key] public int id { get; set; }  //Identificador de cargos
        public string? nombre { get; set; } //Nombre del cargo
    }
}
