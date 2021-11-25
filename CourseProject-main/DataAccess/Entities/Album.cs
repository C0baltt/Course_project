using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
 
namespace DataAccess.Entities
{
    public class Album
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public Guid ArtistId { get; set; }

        public Artist Artist { get; set; }

        public int Year { get; set; }

        public ICollection<Song> Songs;
    }
}
