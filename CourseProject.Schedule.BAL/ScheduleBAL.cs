using CourseProject.Schedule.BAL.Interfaces;
using CourseProject.Schedule.DAL.Interfaces;

namespace CourseProject.Schedule.BAL
{
    public class ScheduleBAL : IBaseService
    {
        private IRepository _repository;

        public object Get(object studentGroup)
        {
            return _repository.Get(studentGroup);
        }

        public object Groups()
        {
            return _repository.Groups();
        }

        public void Update()
        {
            _repository.Update();
        }
    }
}
