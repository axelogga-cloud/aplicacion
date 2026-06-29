using System.ComponentModel.DataAnnotations;
namespace aplicacion.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
