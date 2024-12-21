using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IMath<T>
    {
        T Add(T value1 , T value2);
        T Subtract(T value1, T value2);
    }
    class Scores : IMath<int>
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
        public int Subtract(int value1, int value2)
        {
            int result = 0;
            if(value1 > value2) 
            {
                result = value1 - value2;
            }
            else
            {
                result = value2 - value1;
            }
            return result;
        }
    }
}
