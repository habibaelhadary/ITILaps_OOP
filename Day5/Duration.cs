using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;
        public Duration()
        {
            
        }
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Duration (int seconds)
        {
            this.hours = seconds / 3600;
            this.minutes = (seconds % 3600)/60;
            this.seconds = (seconds )%60;
        }
        public int Hours { get { return hours; } set { hours = value; } }
        public int Minutes{ get { return minutes; } set { minutes = value; } }
        public int Seconds { get { return seconds; } set { seconds = value; } }
        public static Duration operator +(Duration l, Duration r)
        {
            Duration Res = new();
            Res.hours = l.hours + r.hours;
            Res.minutes = l.minutes + r.minutes;
            Res.seconds= l.seconds + r.seconds;
            return Res;
        }
        public static Duration operator +(Duration l, int r)
        {
            Duration Res = new();
            Res.hours = l.hours + r;
            Res.minutes = l.minutes + r;
            Res.seconds = l.seconds + r;
            return Res;
        }
        public static Duration operator +(int l, Duration r)
        {
            Duration Res = new();
            Res.hours = l + r.hours;
            Res.minutes = l + r.minutes;
            Res.seconds = l + r.seconds;
            return Res;
        }
        public static Duration operator ++(Duration P)
        {
            Duration Res = new(); //=> X , Y=0
            Res.minutes = P.minutes + 1; ;
            
            return Res;
        }
        public static Duration operator --(Duration P)
        {
            Duration Res = new(); //=> X , Y=0
            Res.minutes = P.minutes - 1; ;
          
            return Res;
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            //  Console.WriteLine("ay7aga");
            if (d1.hours > d2.hours && d1.minutes > d2.minutes &&d1.minutes>d2.minutes) return true;
            else return false;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            //  Console.WriteLine("ay7aga");
            if (d1.hours < d2.hours && d1.minutes < d2.minutes && d1.minutes < d2.minutes) return true;
            else return false;
        }
        public static explicit operator DateTime(Duration d1)
        {
            return new DateTime(d1.hours, d1.minutes, d1.seconds);
        }
        public override string ToString()
        {
            return $"Housr:{hours} Min:{minutes} Sec:{seconds}";
        }

    }
}
