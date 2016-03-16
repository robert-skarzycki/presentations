using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skarzycki.robert.unittests._01CalcLibrary
{
    public class Calculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sum(params int[] elements)
        {
            return elements.Sum();
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
