using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Song
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public Guid ArtistId { get; set; }

        public Artist Artist { get; set; }

        public Genre Genre { get; set; }

        public Guid AlbumId { get; set; }

        public Album Album { get; set; }

        public Guid UserId { get; set; }
        
        public User User { get; set; }

        public AlbumSong AlbumSong { get; set; }

        public TrackList TrackList { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
