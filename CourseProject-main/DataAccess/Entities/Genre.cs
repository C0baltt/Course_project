using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Genre
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public string AlternateNames { get; set; }
    }
}
