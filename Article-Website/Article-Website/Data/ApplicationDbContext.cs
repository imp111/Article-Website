using Article_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Article_Website.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }
    }
}
