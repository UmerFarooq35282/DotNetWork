using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void PractiveDelegate();
    delegate T OneArgDelegate<T>(T arg); 
    delegate T TwoArgDelegate<T>(T arg , T arg1);
    internal interface Firstinterface 
    {
        void Practice();
        void Add();
        void Remove();

    }

    internal class PracticeGenericTypes : Firstinterface
    {
        public void Add()
        {
            Console.WriteLine("Hey I Am Add()");
        }

        public void Practice()
        {
            Console.WriteLine("Hey I Am Practice()");
        }

        public void Remove()
        {
            Console.WriteLine("Hey I Am Remove()");
        }
        public void abc()
        {
            Console.WriteLine("Hey I Am ABC()");
        }
    }
    class Integers
    {
        public int Adding(int a , int b)
        {
            return a + b;
        }
        public int Subtracting(int a, int b)
        {
            return a - b;
        }
        public int Multiplying(int a, int b)
        {
            return a * b;
        }
        public int Dividing(int a, int b)
        {
            int result = 0;
            if( b != 0)
            {
                return a / b;
            }
            else
            {
                return 505;
            }
            return result;
        }
    }
}
