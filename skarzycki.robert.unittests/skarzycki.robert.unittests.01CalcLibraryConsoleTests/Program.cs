using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skarzycki.robert.unittests._01CalcLibraryConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new _01CalcLibrary.Calculator();

            Console.WriteLine("Test 1: Suma dwóch składników");
            var x = 10;
            var y = 11;
            var result = calculator.Sum(x, y);
            if (result != x + y)
                Console.Error.WriteLine("Niepoprawny wynik: {0} zamiast {1}", result, x + y);
            else
                Console.WriteLine("Test OK");

            Console.ReadKey();
        }
    }
}
