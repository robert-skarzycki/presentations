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
            var expected = x + y;
            
            
            // ---

            var result = calculator.Sum(x, y);

            // ----

            if (result != expected)
                Console.Error.WriteLine("Niepoprawny wynik: {0} zamiast {1}", result, expected);
            else
                Console.WriteLine("Test OK");

            Console.ReadKey();






            calculator = new _01CalcLibrary.Calculator();

            Console.WriteLine("Test 2: Suma dwóch składników, jeden ujemny");
            var x2 = -1;
            var y2 = 11;
            var result2 = calculator.Sum(x2, y2);
            if (result2 != x2 + y2)
                Console.Error.WriteLine("Niepoprawny wynik: {0} zamiast {1}", result2, x2 + y2);
            else
                Console.WriteLine("Test OK");

            Console.ReadKey();
        }
    }
}
