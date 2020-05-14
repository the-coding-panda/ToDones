using Microsoft.EntityFrameworkCore;
using ToDones.Data.Models;

namespace ToDones.Data.Data
{
    public class ToDonesContext : DbContext
    {
        public ToDonesContext()
        {

        }
        public ToDonesContext(DbContextOptions<ToDonesContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-NUM8R1K;Database=ToDones;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryTask>()
                .HasKey(t => new { t.TaskId, t.CategoryId })
                ;

            modelBuilder.Entity<CategoryTask>()
                .HasOne(pt => pt.Task)
                .WithMany(p => p.CategoryTasks)
                .HasForeignKey(pt => pt.TaskId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CategoryTask>()
                .HasOne(pt => pt.Category)
                .WithMany(t => t.CategoryTasks)
                .HasForeignKey(pt => pt.CategoryId).OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTask> CategoryTasks { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TimeLog> TimeLogs { get; set; }

    }
}
