using System.Collections.Generic;

namespace CourseProject.Schedule.DAL.Interfaces
{
    public interface IScheduleRepository
    {
        IEnumerable<string> GetGroups();
        IEnumerable<Models.Schedule> GetSchedules(string group);
        void AddSchedules(IEnumerable<Models.Schedule> schedules);
    }
}
