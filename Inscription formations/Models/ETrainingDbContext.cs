using Microsoft.EntityFrameworkCore;

namespace Inscription_formations.Models
{
    public class ETrainingDbContext : DbContext
    {
        public ETrainingDbContext(DbContextOptions<ETrainingDbContext> options) : base(options)
        {
        }

        public DbSet<Training> Trainings { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships between entities (e.g., one-to-many between Training and Enrollment)
        }
    }   
}
