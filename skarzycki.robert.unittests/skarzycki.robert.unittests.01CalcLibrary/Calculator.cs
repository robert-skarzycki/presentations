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
            //Console.WriteLine("Witaj, {0}", name);
            x = MakeZeroIfNegative(x);
                        
            return x + y;
        }

        #region Private methods
        private int MakeZeroIfNegative(int x)
        {
            if (x < 0)
                return 0;

            return x;
        }

        #endregion


        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
