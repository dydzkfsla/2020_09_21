using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_21
{
    class Class2
    {
        static int Divide(int x, int y,out int mod)
        {
            mod = x % y;
            return x / y;
        }

        static void Main()
        {
            int x = 10;
            int y = 4;
            int mod;
            int result = Divide(x, y,out mod);
            Console.WriteLine($"몫: {result}  나머지: {mod}");
        }
    }
}
