using Microsoft.EntityFrameworkCore;
using schedule_aspcore_service.Models;

namespace schedule_aspcore_service.Data
{
    public class SchedulerDbContext: DbContext
    {
        public SchedulerDbContext(DbContextOptions<SchedulerDbContext> options) : base(options)
        {

        }
        public DbSet<ScheduleModel> ScheduleTableAspCore { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduleModel>().HasData(
                new ScheduleModel { Id = 1, Subject="Intial item", StartTime=new DateTime(2024,6,11), EndTime=new DateTime(2024,6,12)}
                );
        }
    }
}
