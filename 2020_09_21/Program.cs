using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _2020_09_21
{
    class Time
    {
        private int hours = 0;
        private int minutes = 0;

        #region 생성자
        public Time(int minutes) : this(0, minutes)
        {

        }

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            Examine();
        }
        #endregion

        #region 프로퍼티
        public int Minutes { get => minutes; set => minutes = value; }
        public int Hours { get => hours; set => hours = value; }
        #endregion

        #region 재정의 메서드
        public override string ToString()
        {
            return $"{hours} : {minutes}";
        }

        public override bool Equals(object obj)
        {
            return obj is Time temp && temp.Hours == this.hours && temp.Minutes == this.minutes;
        }
        #endregion

        #region 내부 메서드
        private int TotalMinutes()
        {
            return hours * 60 + minutes;
        }

        private void Examine()
        {
            if (hours < 0 || minutes < 0)
            {
                Console.WriteLine("올바르지 않은 입력값입니다.");
                return;
            }

            hours = hours + (minutes / 60);
            minutes = minutes % 60;
        }
        #endregion

        #region 연산자
        
        public static bool operator ==(Time a, Time b) => a.minutes == b.minutes && a.hours == b.hours;
        public static bool operator !=(Time a, Time b) => !(a.minutes == b.minutes && a.hours == b.hours);

        public static Time operator +(Time a, Time b) => new Time(a.TotalMinutes() + b.TotalMinutes());

        public static Time operator ++(Time a) => new Time(a.TotalMinutes() + 1);

        public static bool operator >(Time a, Time b) => a.TotalMinutes() > b.TotalMinutes();
        public static bool operator <(Time a, Time b) => a.TotalMinutes() < b.TotalMinutes();
        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(1, 40);
            Console.WriteLine(t1.ToString());

            Time t2 = new Time(1, 20);

            Console.WriteLine(t1 == t2);

            Time t3 = t1 + t2;
            Console.WriteLine(t3.ToString());

            t3++;
            Console.WriteLine(t3.ToString());

            Console.WriteLine(t1 > t2);
       }
    }
}
