using System.ComponentModel.DataAnnotations;
using System.Timers;
using Tipo_Datos.Models.Entidades.Base;

namespace Tipo_Datos.Models.Entidades
{
    public class UsuarioModel: BaseModel
    {
        [EmailAddress(ErrorMessage ="El formato no de correo electronico")]
        [Required(ErrorMessage ="El campo es requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Password { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public  string ConfirmPassword { get; set; }
    }
}
