using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)

        : base(options)

        {
            Database.EnsureCreated();
        }
    }
}
