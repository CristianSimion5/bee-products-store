using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Polifloris.ViewModels
{
    public class DetailsRoleViewModel
    {
        public DetailsRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string RoleName { get; set; }
    
        public List<string> Users { get; set; }
    }
}
