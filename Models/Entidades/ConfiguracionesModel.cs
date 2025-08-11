using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tipo_Datos.Models.Entidades.Base;

namespace Tipo_Datos.Models.Entidades
{
    [Table("ConfiguracionesEmpresa")]
    public class ConfiguracionesModel:BaseModel
    {
        [Required(ErrorMessage ="El campo es requerido")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Nombre_Empresa { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [EmailAddress(ErrorMessage ="No posee el formato correcto")]
        public string Email { get; set; }
        public string? Web { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [Phone(ErrorMessage = "No posee el formato correcto")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string RUC { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Contrasenia { get; set; }
    }
}
