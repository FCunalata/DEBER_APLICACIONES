using System.ComponentModel.DataAnnotations;

namespace Tipo_Datos.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="El campo es requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Password { get; set; }
    }
}
