using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class OrderItem {
        
        [Key]
        public int OrderItemId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public virtual Product Product { get; set; }
    }
}