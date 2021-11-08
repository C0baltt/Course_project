using System;

namespace DataAccess.Entities
{
    public class AlbumSong
    {
        public Guid AlbumId { get; set; }

        public Album Album { get; set; }

        public Guid SongId { get; set; }

        public Song Song { get; set; }
    }
}
