using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class AlbumSong
    {
        public Guid AlbumId { get; set; }

        public Album Album { get; set; }

        public Guid SongId { get; set; }

        public Song Song { get; set; }

        public ICollection<Song> Songs { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
