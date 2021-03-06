using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Users
{
    public class CreateUserViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Range(1, 100)]
        public int? Age { get; set; }
    }
}
