using System;
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
        public override DbSet<User> Users { get; set; }
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
                .WithMany(x => x.Songs)
                .HasForeignKey(x => x.ArtistId);
            
            builder.Entity<Song>()
                .HasOne(x => x.Genre)
                .WithMany(x => x.Songs)
                .HasForeignKey(x => x.Genre);

            builder.Entity<Album>()
                .HasOne(x => x.Artist)
                .WithMany(x => x.Albums)
                .HasForeignKey(x => x.ArtistId);

            builder.Entity<AlbumSong>()
                .HasMany(x => x.Album)
                .WithMany(x => x.Songs)
                .HasForeignKey(x => x.Song.Id);

            builder.Entity<AlbumSong>()
                .HasMany(x => x.Song)  
                .WithMany(x => x.Albums)
                .HasForeignKey(x => x.AlbumId);

            builder.Entity<User>()
                .HasMany(x => x.Songs)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.Entity<TrackList>()
                .HasMany(x => x.Songs)
                .WithOne(x => x.TrackList)
                .HasForeignKey(x => x.TrackList.Id);

            builder.Entity<TrackList>()
                .HasOne(x => x.User)
                .WithMany(x => x.TrackLists)
                .HasForeignKey(x => x.Id);
            
        }
    }
}