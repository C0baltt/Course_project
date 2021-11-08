using System.ComponentModel.DataAnnotations;
using System;

namespace WebApp.Models.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
