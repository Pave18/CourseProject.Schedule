using CourseProject.Schedule.BAL.Interfaces;
using CourseProject.Schedule.DAL;
using CourseProject.Schedule.DAL.Interfaces;
using System.Collections.Generic;
using System;

namespace CourseProject.Schedule.BAL
{
    public class ScheduleBAL : IBaseService
    {
        private IRepository _repository;
        private IEnumerable<object> Db;

        public ScheduleBAL()
        {
            _repository = new ScheduleRepository();
            Db = _repository.Get();
        }
        
        public IEnumerable<object> GetGroups()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetSchedules()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            _repository.Update();
        }
    }
}
