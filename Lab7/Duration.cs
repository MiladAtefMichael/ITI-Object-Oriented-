using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Duration
    {
        public TimeSpan Time { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Time = new TimeSpan(hours, minutes, seconds);

        }
        public Duration(int minutes, int seconds)
        {
            Time = new TimeSpan(0, minutes, seconds);
        }
        public Duration(int seconds)
        {
            Time = new TimeSpan(0, 0, seconds);
        }
        public void print()
        {
            Console.WriteLine($"Hours = {Time.Hours} , Minutes = {Time.Minutes}, Seconds = {Time.Seconds}");
        }
        public static Duration operator +(Duration a, Duration b)
        {
            TimeSpan c= a.Time + b.Time;
            Duration duration=new Duration(c.Seconds);
            return duration;
        }
        public static Duration operator +(Duration a, int b)
        {
            int c_seconds = a.Time.Seconds+b;
            Duration duration = new Duration(c_seconds);
            return duration;
        }
        public static Boolean operator >(Duration a, Duration b)
        {


            return  a.Time.Seconds > b.Time.Seconds ? true : false ;
        }
        public static Boolean operator <(Duration a, Duration b)
        {


            return a.Time.Seconds <= b.Time.Seconds ? true : false ;
        }
    }
}
