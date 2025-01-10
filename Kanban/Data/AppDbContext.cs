using Kanban.Models;
using Microsoft.EntityFrameworkCore;

namespace Kanban.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<ActivityModel> Activities { get; set; }
        public DbSet<ActivityModel> Status { get; set; }

        //Initializing the Status table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusModel>().HasData(
                new StatusModel { Id = 1, Name="Pending"},
                new StatusModel { Id = 2, Name="OnGoing"},
                new StatusModel { Id = 3, Name="Done"}
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
