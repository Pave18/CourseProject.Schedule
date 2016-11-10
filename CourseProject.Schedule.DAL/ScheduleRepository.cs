using CourseProject.Schedule.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CourseProject.Schedule.DAL
{
    class ScheduleRepository : IRepository
    {
        ScheduleContext context = new ScheduleContext();

        public object Get(object studentGroup)
        {
            var result = (from s in context.Schedules where s.studentGroup == studentGroup.ToString() select s).FirstOrDefault();
            return result;
        }

        public object Groups()
        {
            var result = (from s in context.Schedules select s.studentGroup).FirstOrDefault();
            return result;
        }

        public void Update()
        {
            using (XmlTextReader reader = new XmlTextReader("XMLFileDB.xml"))
            {

            }
        }
    }
}
