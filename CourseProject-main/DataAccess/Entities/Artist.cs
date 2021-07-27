using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    class Artist
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }
    }
}
