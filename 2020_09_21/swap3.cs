using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_21
{
    class Point
    {
        public int x = 10;
        public int y = 5;
    }

    class swap3
    {
        static void swap(Point p1)
        {
            Point point = new Point();
            point.x = p1.x;
            point.y = p1.y;
            int temp = point.y;
            point.y = point.x;
            point.x = temp;
        }

        static void Main()
        {
            Point p1 = new Point();

            p1.x = 3;
            p1.y = 5;

            Console.WriteLine($"{p1.x} : {p1.y}");
            Console.WriteLine($"{p1.x} : {p1.y}");
        }
    }
}
