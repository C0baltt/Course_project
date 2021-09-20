using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    class Album
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public Guid ArtistId { get; set; }

        public Artist Artist { get; set; }

        public int Year { get; set; }

        //TODO class CoverPhoto
    }
}
