using System.Collections.Generic;

namespace CourseProject.Schedule.BAL.Interfaces
{
    public interface IScheduleService
    {
        IEnumerable<DAL.Models.Schedule> GetSchedulesFromNetwork();
    }
}
