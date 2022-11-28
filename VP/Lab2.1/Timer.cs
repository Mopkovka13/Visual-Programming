using System;
using System.Windows.Forms;

namespace Lab2._1
{
    internal class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        
        public Timer(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int GetSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Timer operator - (Timer t1, Timer t2)
        {
            int seconds = t1.GetSeconds() - t2.GetSeconds();
            int resultHours = (seconds / 3600);
            seconds -= resultHours * 3600;
            int resultMinutes = (seconds / 60);
            seconds -= resultMinutes * 60;
            return new Timer(resultHours, resultMinutes, seconds);

        }

        public static Timer operator +(Timer t1, Timer t2)
        {
            int seconds = t1.GetSeconds() + t2.GetSeconds();
            int resultHours = (seconds / 3600);
            seconds -= resultHours * 3600;
            int resultMinutes = (seconds / 60);
            seconds -= resultMinutes * 60;
            return new Timer(resultHours, resultMinutes, seconds);

        }
    }
}
