using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_21
{
    class Class3
    {
        static int Sum(params int[] arr)
        {
            int tot = 0;
            foreach(int num in arr)
            {
                tot += num;
            }
            return tot;
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sum(int x, int y, int c, int d)
        {
            return x + y + c + d;
        }
        static void Main()
        {
            int temp = Sum(3, 5);

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int result = Sum(arr);
            Console.WriteLine(result);


            Console.WriteLine(Sum(new int[10] { 1,2,3,4,5,6,7,8,9,10}));

            Console.WriteLine(Sum(1,2,3,4,5,6,7,8,8,9,9,1,23,1,23,2,3,1,23));
        }
    }
}
