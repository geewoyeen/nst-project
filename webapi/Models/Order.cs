using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Order {
        
        [Key]
        public int OrderId { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public string AdressForDelivery { get; set; }
        [Required]
        public string NameForDelivery { get; set; }
        [Required]
        public string Status { get; set; }     
        [Required]
        public int UserId { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}