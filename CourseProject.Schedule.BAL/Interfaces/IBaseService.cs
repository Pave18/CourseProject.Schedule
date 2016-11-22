using System.Collections.Generic;

namespace CourseProject.Schedule.BAL.Interfaces
{
    public interface IBaseService
    {
        IEnumerable<DAL.Models.Schedule> GetSchedules(string group);
        IEnumerable<string> GetGroups();
    }
}
