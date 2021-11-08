using System.ComponentModel.DataAnnotations;
using System;

namespace WebApp.Models.Users
{
    public class CreateUserViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
