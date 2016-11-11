using CourseProject.Schedule.BAL.Interfaces;
using CourseProject.Schedule.DAL;
using CourseProject.Schedule.DAL.Interfaces;
using System.Collections.Generic;

namespace CourseProject.Schedule.BAL
{
    public class ScheduleBAL : IBaseService
    {
        private IRepository _repository = new ScheduleRepository();

        public IEnumerable<object> Get()
        {
            return _repository.Get();
        }

        public void Update()
        {
            _repository.Update();
        }
    }
}
