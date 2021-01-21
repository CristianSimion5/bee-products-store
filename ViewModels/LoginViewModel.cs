using System.ComponentModel.DataAnnotations;

namespace Polifloris.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Nume de utilizator")]
        public string Username { get; set; }
        
        [Required]
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
