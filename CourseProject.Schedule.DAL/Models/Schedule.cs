namespace CourseProject.Schedule.DAL.Models
{
    public class Schedule
    {
        public int scheduleId { get; set; }

        public string weekDay { get; set; }
        public string auditory { get; set; }
        public Employee employee { get; set; }
        public string lessonTime { get; set; }
        public string lessonType { get; set; }
        public string note { get; set; }
        public int numSubgroup { get; set; }
        public string studentGroup { get; set; }
        public string subject { get; set; }
        public bool zaoch { get; set; }        
    }
}
