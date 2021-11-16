using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Artist
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        public ICollection<Song> Songs { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
