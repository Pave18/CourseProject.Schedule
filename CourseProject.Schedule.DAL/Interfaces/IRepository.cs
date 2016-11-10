namespace CourseProject.Schedule.DAL.Interfaces
{
    interface IRepository
    {
        object Get(object studentGroup);
        object Groups();
        void Update();
    }
}
