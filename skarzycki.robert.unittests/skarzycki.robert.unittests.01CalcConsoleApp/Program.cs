using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skarzycki.robert.unittests._01CalcConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwszy składnik: ");
            var xStr = Console.ReadLine();
            int x;
            int.TryParse(xStr, out x);

            Console.WriteLine("Drugi składnik: ");
            var yStr = Console.ReadLine();
            int y;
            int.TryParse(yStr, out y);

            Console.WriteLine("Suma: {0}", Sum(x, y));
            Console.WriteLine("\n[Naciśnij, aby zamknąć]");

            Console.ReadKey();
        }

        private static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
