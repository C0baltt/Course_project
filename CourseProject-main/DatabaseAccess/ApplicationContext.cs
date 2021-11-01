using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess
{
    public class ApplicationContext : DdContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)

        : base(options)

        {
            Database.EnsureCreated();
        }
    }
}
