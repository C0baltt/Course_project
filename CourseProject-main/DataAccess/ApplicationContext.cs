using System;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public class ApplicationContext : DbContext
    {

        private readonly IServiceProvider _serviceProvider;

        public DbSet<Song> Songs { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<TrackList> TrackLists { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }

        public ApplicationContext(
            IServiceProvider serviceProvider,
            DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            _serviceProvider = serviceProvider;
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        private void CreateTrackList(ModelBuilder builder)
        {
            //builder.Entity<Album>()
            //    .

                //builder.Entity<User>()
                //.

            //builder.Entity<AlbumSong>()
            //    .
        }
    }
}