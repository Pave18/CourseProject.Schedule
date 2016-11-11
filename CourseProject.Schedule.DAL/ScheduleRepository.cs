using CourseProject.Schedule.DAL.Interfaces;
using System;
using System.Linq;
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
            XmlDocument document = new XmlDocument();
            document.Load(@"XMLFileDB.xml");

            try
            {
                foreach (XmlNode node in document.SelectNodes("/scheduleXmlModels/scheduleModel"))
                {
                    Models.Employee Empl = new Models.Employee() { };
                    Models.Schedule Sched = new Models.Schedule() { employee = Empl };

                    Sched.weekDay = node.LastChild.InnerText; //weekdays

                    for (int i = 0; i < node.ChildNodes.Count - 1; i++)
                    {
                        for (int j = 0; j < node.ChildNodes[i].ChildNodes.Count; j++)
                        {
                            if (node.ChildNodes[i].ChildNodes[j].Name == "auditory")
                            {
                                Sched.auditory = node.ChildNodes[i].ChildNodes[j].InnerText;
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "employee")
                            {
                                for (int k = 0; k < node.ChildNodes[i].ChildNodes[j].ChildNodes.Count; k++)
                                {
                                    if (node.ChildNodes[i].ChildNodes[j].ChildNodes[k].Name == "id")
                                        Empl.employeeId = Int32.Parse(node.ChildNodes[i].ChildNodes[j].ChildNodes[k].InnerText);
                                    if (node.ChildNodes[i].ChildNodes[j].ChildNodes[k].Name == "academicDepartment")
                                        Empl.academicDepartment = node.ChildNodes[i].ChildNodes[j].ChildNodes[k].InnerText;
                                    if (node.ChildNodes[i].ChildNodes[j].ChildNodes[k].Name == "firstName")
                                        Empl.firstName = node.ChildNodes[i].ChildNodes[j].ChildNodes[k].InnerText;
                                    if (node.ChildNodes[i].ChildNodes[j].ChildNodes[k].Name == "lastName")
                                        Empl.lastName = node.ChildNodes[i].ChildNodes[j].ChildNodes[k].InnerText;
                                }
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "lessonTime")
                            {
                                Sched.lessonTime = node.ChildNodes[i].ChildNodes[j].InnerText;
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "lessonType")
                            {
                                Sched.lessonType = node.ChildNodes[i].ChildNodes[j].InnerText;
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "note")
                            {
                                Sched.note = node.ChildNodes[i].ChildNodes[j].InnerText;
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "numSubgroup")
                            {
                                Sched.numSubgroup = Int32.Parse(node.ChildNodes[i].ChildNodes[j].InnerText);
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "studentGroup")
                            {
                                Sched.studentGroup = node.ChildNodes[i].ChildNodes[j].InnerText;
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "subject")
                            {
                                Sched.subject = node.ChildNodes[i].ChildNodes[j].InnerText;
                            }
                            if (node.ChildNodes[i].ChildNodes[j].Name == "zaoch")
                            {
                                Sched.zaoch = Boolean.Parse(node.ChildNodes[i].ChildNodes[j].InnerText);
                            }
                        }
                        context.Schedules.Add(Sched);
                    }
                }
            }
            catch (OperationCanceledException)
            {}
        }
    }
}
