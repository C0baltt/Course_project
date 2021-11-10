﻿using System;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationContext : IdentityDbContext<User> //DbContext
    {
        private readonly IServiceProvider _serviceProvider;

        public DbSet<Song> Songs { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<TrackList> TrackLists { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }

        public ApplicationContext(IServiceProvider serviceProvider,  DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
         
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Song>()
                .HasOne(x => x.Artist)
                .WithMany(x => x.Song)
                .HasForeignKey(x => x.ArtistId);

            builder.Entity<Album>()
                .HasOne(x => x.Artist)
                .WithMany(x => x.Album)
                .HasForeignKey(x => x.ArtistId);

            builder.Entity<AlbumSong>()
                .HasMany(x => x.Album)
                .WithMany(x => x.Song)
                .HasForeignKey(x => x.AlbumId);

            builder.Entity<AlbumSong>()
                .HasMany(x => x.Song)
                .WithMany(x => x.Album)
                .HasForeignKey(x => x.SongId);  
        }
    }
}