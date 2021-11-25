using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Genre
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public string AlternateNames { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
