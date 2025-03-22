using System.ComponentModel.DataAnnotations;

namespace NeXusERP.WebUI.Models
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "El Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email no es válido")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatorio")]
        public string password { get; set; } = string.Empty;
    }
}
