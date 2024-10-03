using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Empresas
    {
        [Key] public int id { get; set; } //Identificador de la empresa
        public int cod_empresa { get; set; } //Es un codigo que identifica a la empresa
        public string? nombre { get; set; } //Corresponde al nombre que posea esa Empresa
        public string? direccion {  get; set; } //Direccion de la empresa
    }

}
