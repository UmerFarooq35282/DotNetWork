using System;

namespace ConsoleApp1
{
    internal interface IDetail
    {
        void DisplayDetail();
    }
    internal class GenericInterfaceConstraint<T> where T : IDetail
    {
        
        T[] values = new T[3];
        int index = 0;

        public void Add(T obj)
        {
            values[index] = obj;
            index++;
            
        }

        public void ListDisplayDetail()
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i].DisplayDetail();
            }
        }
    }

    class Student : IDetail
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Salary;

        public Student(int StdId, string StdName, string StdDis, int salary)
        {
            id = StdId;
            Name = StdName;
            Description = StdDis;
            Salary = salary;
        }
        public void DisplayDetail()
        {
            Console.WriteLine(id + " | " + Name + " | " + Description + " | " + " Salary : " + Salary);
            
        }
    }
    class Course : IDetail
    {
        public int id { get; set; }
        public string CourseName { get; set; }

        public string[] Days { get; set; }

        public Course(int CourseId, string courseName , string[] days)
        {
            id = CourseId;
            CourseName = courseName;
            Days = days;
        }

        public void DisplayDetail()
        {
            Console.WriteLine(id + " | " + CourseName + " | " + " Days | " + Days[0] + Days[1] + Days[2]);   
        }
    }
}
