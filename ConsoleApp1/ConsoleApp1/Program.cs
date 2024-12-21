using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum ArrivalStatus { Unknown = -3, Late = -1, OnTime = 0, Early = 1 };
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scores scores = new Scores();
            //Console.WriteLine("Total Score Is : " + scores.Add(10, 20));
            //Console.WriteLine("Score Difference : " + scores.Subtract(10, 20));

            //GenericInterfaceConstraint<Student> students = new GenericInterfaceConstraint<Student>();
            //students.Add(new Student(1,"Umer","Programer",45000));
            //students.Add(new Student(2, "Uzair", "Designer",40000));
            //students.Add(new Student(3, "Mustafa", "Editor",44000));
            //students.ListDisplayDetail();

            //GenericInterfaceConstraint<Course> course = new GenericInterfaceConstraint<Course>();
            //string[] TTS = { " Tuesday " , " Thursday " , " Satuarday "};
            //string[] MWF = { " Monday ", " Wednesday ", " Friday " };
            //course.Add(new Course(1, "Chemistry", TTS));
            //course.Add(new Course(2, "Physics",MWF));
            //course.Add(new Course(3, "Maths", TTS));
            //course.ListDisplayDetail();

            //Console.WriteLine("Enter First Number Here ");
            //int firstNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number Here ");
            //int SecondNum = int.Parse(Console.ReadLine());
            //TwoArgDelegate<int> sum = new Integers().Adding;
            //TwoArgDelegate<int> mult = new Integers().Multiplying;
            //TwoArgDelegate<int> sub = new Integers().Subtracting;
            //TwoArgDelegate<int> div = new Integers().Dividing;

            //Console.WriteLine("Sum Is : " + sum(firstNum,SecondNum));
            //Console.WriteLine("Subtraction Is : " + sub(firstNum, SecondNum));
            //Console.WriteLine("Multiplication Is : " + mult(firstNum, SecondNum));
            //Console.WriteLine("Division Is : " + div(firstNum, SecondNum));

            //int[] values = { -3, -1, 0, 1, 5, Int32.MaxValue };
            //foreach (var value in values)
            //{
            //    ArrivalStatus status;
            //    if (Enum.IsDefined(typeof(ArrivalStatus), value))
            //        status = (ArrivalStatus)value;
            //    else
            //        status = ArrivalStatus.Unknown;
            //    Console.WriteLine("Converted {0:N0} to {1}", value, status);
            //}
            /*
             
            Func<int,int> sqr = x => x * x;
            Console.WriteLine(sqr(5));
            Console.WriteLine(sqr(10));
            Console.WriteLine(sqr(15));
            Console.WriteLine(sqr(20));

            */

            /*
             
            int[] numbers = { 1, 2, 3, 4, 5, };
            var selectNumber = numbers.Select(x => x * x);
            Console.WriteLine(string.Join( " " , selectNumber));
            Action<string> greet = name =>
            {
               string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("Umer Farooq");
            greet("Rehan Ramzan");

            */

            /*
             
            Action<int,int,bool> sqr1 = (value1 , value2 , res) =>
            {
                if(value1  == value2)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                Console.WriteLine(res);
            };
            sqr1(10,10,true);

            */

            

        }


    }
}
