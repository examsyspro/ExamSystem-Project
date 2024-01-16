using ExamSystem.ServerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.ServerAPI.DbModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
                
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<OptionAns> OptionAns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }  // This line was missing


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships, constraints, etc., if needed
            base.OnModelCreating(modelBuilder);
        }

    }
}
