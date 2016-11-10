using System.Data.Entity;

namespace CourseProject.Schedule.DAL
{
    class ScheduleContext : DbContext
    {
        public ScheduleContext() : base("name=ScheduleDB") { }

        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.Schedule> Schedules { get; set; }
    }
}
