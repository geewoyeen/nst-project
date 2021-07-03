using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Product {
        
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Brand { get; set; }
    }
}