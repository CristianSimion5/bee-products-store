using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Polifloris.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Required]
        [Display(Name = "Categorie")]
        public string CategoryName { get; set; }
        
        [Required]
        [Display(Name = "Descriere")]
        public string Description { get; set; }
        
        public List<Product> Products { get; set; }
    }
}
