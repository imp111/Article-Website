using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Article_Website.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
        
    }
}
