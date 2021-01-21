using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polifloris.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Nume de utilizator")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirmă Parola")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Parola și parola de confirmare nu sunt egale.")]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; }
    }
}
