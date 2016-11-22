using CourseProject.Schedule.BAL.Interfaces;
using CourseProject.Schedule.DAL;
using CourseProject.Schedule.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject.Schedule.BAL
{
    public class ScheduleBAL : IBaseService
    {
        protected readonly IScheduleService scheduleService;
        protected readonly IScheduleRepository scheduleRepository;

        public ScheduleBAL()
        {
            scheduleService = new ScheduleService();
            scheduleRepository = new ScheduleRepository();
        }

        public IEnumerable<string> GetGroups()
        {
            var groups = scheduleRepository.GetGroups();

            if (!groups.Any())
            {
                Update();

                groups = scheduleRepository.GetGroups();
            }

            return groups;
        }

        public IEnumerable<DAL.Models.Schedule> GetSchedules(string group)
        {
            var schedules = scheduleRepository.GetSchedules(group);

            if (!schedules.Any())
            {
                Update();

                schedules = scheduleRepository.GetSchedules(group);
            }

            return schedules;
        }

        private void Update()
        {
            var schedules = scheduleService.GetSchedulesFromNetwork();

            scheduleRepository.AddSchedules(schedules);
        }
    }
}
