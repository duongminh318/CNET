using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Entities
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MAYTINH;Database=learnEF;User Id=sa;Password=dminh318@;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }
    }
}
