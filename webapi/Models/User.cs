using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class User {
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Active { get; set; }
    }
}