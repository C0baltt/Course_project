﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    class TrackList
    {
        public Guid Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }
       
        public Guid ArtistId { get; set; }

        public Artist Artist { get; set; }

        public Guid SongId { get; set; }

        public Song Song { get; set; }

        [MaxLength(50)]
        public string Unique_Combination { get; set; }

        public Guid UserID { get; set; }

        public User User { get; set; }
    }
}