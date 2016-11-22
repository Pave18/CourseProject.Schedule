using CourseProject.Schedule.BAL.Interfaces;
using CourseProject.Schedule.DAL.Models;
using System.Collections.Generic;
using System.Xml;

namespace CourseProject.Schedule.BAL
{
    public class ScheduleService : IScheduleService
    {
        // типа каешь из нета данные новые
        public IEnumerable<DAL.Models.Schedule> GetSchedulesFromNetwork()
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"XMLFileDB.xml");// пришли условно данные из нета

            var schedules = new List<DAL.Models.Schedule>();

            try
            {
                foreach (XmlNode node in document.SelectNodes("/scheduleXmlModels/scheduleModel"))
                {
                    Employee Empl = new Employee() { };
                    DAL.Models.Schedule Sched = new DAL.Models.Schedule() { employee = Empl };

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
                                        Empl.employeeId = int.Parse(node.ChildNodes[i].ChildNodes[j].ChildNodes[k].InnerText);
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
                                Sched.numSubgroup = int.Parse(node.ChildNodes[i].ChildNodes[j].InnerText);
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
                                Sched.zaoch = bool.Parse(node.ChildNodes[i].ChildNodes[j].InnerText);
                            }
                        }
                        schedules.Add(Sched);
                    }
                }
            }
            catch
            { }

            return schedules;
        }
    }
}
