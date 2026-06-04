using System.ComponentModel.DataAnnotations;
namespace aplicacion.Models
{
    public class LogingViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
