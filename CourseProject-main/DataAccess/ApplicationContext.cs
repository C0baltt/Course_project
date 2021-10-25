using System;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationContext : IdentityDbContext<User>
    {

        private readonly IServiceProvider _serviceProvider;

        public DbSet<Song> Songs { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<TrackList> TrackLists { get; set; }
        public DbSet<User> Users { get; set; }

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
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ConfigureUser(builder);
            ConfigureAccount(builder);
            ConfigureQuiz(builder);
            CreateSeededUser(builder);
            CreateBookStore(builder);
        }
    }
}