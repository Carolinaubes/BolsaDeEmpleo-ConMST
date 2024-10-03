using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Estudios
    {
        [Key] public int id { get; set; } //Identificador de Estudios
        public int cod_estudio {  get; set; } //Es un codigo que identifica a la empresa
        public string? nombre {  get; set; } //Corresponde al nombre del Estudio
    }
}
