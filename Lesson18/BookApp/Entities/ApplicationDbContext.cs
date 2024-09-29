using Ex1GenericRepositoryUOW.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ex1RepositoryUOW.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
