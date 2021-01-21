using System.ComponentModel.DataAnnotations;

namespace Polifloris.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
