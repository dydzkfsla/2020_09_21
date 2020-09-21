using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_21
{
    abstract class Person
    {
        public void Speak()
        {
            Console.WriteLine("Qdd");
        }

        public void Work()
        {
            Console.WriteLine("일을 합니다.");
        }

        public void Study()
        {
            Console.WriteLine("공부를 합니다.");
        }
    }

    //class Employee : Person
    //{
    //    public override void Speak()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Class1
    {
        static void Main()
        {

        }
    }
}
