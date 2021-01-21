using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polifloris.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        
        [Required]
        public int Amount { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
