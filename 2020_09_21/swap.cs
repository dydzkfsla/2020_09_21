using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_21
{

    class swap
    {  
        static void Swap(int i , int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }

        //static void Swap(ref int i,ref int j)
        //{
        //    int temp = i;
        //    i = j;
        //    j = temp;
        //}

        static void Swap(out int i, out int j)
        {
            i = 3; j = 5;
            int temp = i;
            i = j;
            j = temp;
        }


        static void ChWord(string arg)
        {
            arg = "World";
        }


        static void ChWord(ref string arg)
        {
            arg = "World";
        }

        static void Main()
        {
            string str = "Hello";
            ChWord(str);
            Console.WriteLine(str);

            ChWord(ref str);
            Console.WriteLine(str);

        }
    }
}
