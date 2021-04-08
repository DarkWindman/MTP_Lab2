using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new Vector(3, 5, 0);
            var vector2 = new Vector(2, 0, 0);
            var result = vector1 + vector2;
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
