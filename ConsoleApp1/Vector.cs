using System;
using ConsoleApp1;
namespace ConsoleApp1
{
    public class Vector
    {
        public int x, y, z;
        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y, a.z+b.z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector operator *(Vector a, int b)
        {
            return new Vector(a.x * b, a.y * b, a.z*b);
        }

        public int ModuleMultipl(Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y + a.z*b.z;
        }

        public static Vector operator /(Vector a, Vector b)
        {
            return new Vector( a.y * b.z - a.z * b.y, -1 * (a.x * b.z - a.z * b.x), a.x * b.y - a.y * b.x );
        }
    }
}
