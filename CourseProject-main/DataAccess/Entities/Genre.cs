using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Genre
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string AlternateNames { get; set; }
    }
}
