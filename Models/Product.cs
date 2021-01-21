using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polifloris.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageThumbnailUrl { get; set; }
        
        [Required]
        public bool InStock { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }
    }
}
