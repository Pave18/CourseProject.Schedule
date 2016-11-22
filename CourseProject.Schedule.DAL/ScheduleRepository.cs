using CourseProject.Schedule.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject.Schedule.DAL
{
    public class ScheduleRepository : IScheduleRepository
    {
        public IEnumerable<Models.Schedule> GetSchedules(string group)
        {
            using (var context = new ScheduleContext())
            {
                return context.Schedules.Where(x => x.studentGroup.Equals(group)).ToList();
            }
        }

        public IEnumerable<string> GetGroups()
        {
            using (var context = new ScheduleContext())
            {
                return context.Schedules.Select(x => x.studentGroup).Distinct().ToList();
            }
        }

        public void AddSchedules(IEnumerable<Models.Schedule> schedules)
        {
            using (var context = new ScheduleContext())
            {
                context.Schedules.AddRange(schedules);
                context.SaveChanges();
            }
        }
    }
}
