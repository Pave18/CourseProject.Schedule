using System.Collections.Generic;

namespace CourseProject.Schedule.DAL.Interfaces
{
    public interface IRepository
    {
        IEnumerable<object> Get();
        void Update();
    }
}
