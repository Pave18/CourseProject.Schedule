﻿namespace CourseProject.Schedule.DAL.Interfaces
{
    public interface IRepository
    {
        object Get(object studentGroup);
        object Groups();
        void Update();
    }
}
