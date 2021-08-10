using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class User : IdentityUser
    {
        //public int Age { get; set; }

        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
