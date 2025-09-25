using Microsoft.EntityFrameworkCore;

namespace LmsApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
