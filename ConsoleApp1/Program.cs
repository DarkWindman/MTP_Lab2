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
            int[] vec1 = new int[] { 2, 5 };
            int[] vec2 = new int[] { 3, 0 };
            var vector = new Vector();
            vector.Sloz(vec1, vec2);
            Console.ReadKey();

        }

    }
    public class Vector
    {
        public int[] Sloz(int[] vec1, int[] vec2)
        {
            return new int[] { vec1[0] + vec2[0], vec1[1] + vec2[1] };
        }

        public int[] Otnim(int[] vec1, int[] vec2)
        {
            return new int[] { vec1[0] - vec2[0], vec1[1] - vec2[1] };
        }

        public int[] Umnoz(int[] vec1, int a)
        {
            return new int[] { vec1[0] * a, vec1[1] * a };
        }

        public int Skalar(int[] vec1, int[] vec2)
        {
            return vec1[0] * vec2[0] + vec1[1] * vec2[1];
        }

        public int[] Vectorne(int[] vec1, int[] vec2)
        {
            return new int[] { vec1[1] * vec2[2] - vec1[2] * vec2[1], -1 * (vec1[0] * vec2[2] - vec1[2] * vec2[0]), vec1[0] * vec2[1] - vec1[1] * vec2[0] };
        }
    }
}
