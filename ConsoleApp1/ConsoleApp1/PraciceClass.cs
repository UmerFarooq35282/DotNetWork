using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PraciceClass
    {
        private int Rows;
        private int Columns;

        public readonly PraciceClass Up = new PraciceClass(0,-1);
        private PraciceClass(int row , int col)
        {
            Rows = row;
            Columns = col;
        }

        public PraciceClass abc()
        {
            return this;
        }
        
             
    }
}
