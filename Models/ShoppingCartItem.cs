using System.ComponentModel.DataAnnotations;

namespace Polifloris.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }
        
        public Product Product { get; set; }
        
        [Required]
        public int Amount { get; set; }
        
        public string ShoppingCartId { get; set; }
    }
}
