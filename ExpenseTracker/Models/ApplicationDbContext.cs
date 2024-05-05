using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
