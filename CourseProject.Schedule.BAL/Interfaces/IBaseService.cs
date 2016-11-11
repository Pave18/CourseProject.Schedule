using System.Collections.Generic;

namespace CourseProject.Schedule.BAL.Interfaces
{
    public interface IBaseService
    {
        IEnumerable<object> Get();
        void Update();
    }
}
