using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Timer
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Timer(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public Timer() : this(0, 0, 0) { }

        public bool Equals(Timer time)
        {
            if (time.Hour != this.Hour || time.Minute != this.Minute || time.Second != this.Second)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // 按秒走时
        public void TimeGo()
        {
            this.Second++;
            if (Second >= 60)
            {
                Minute++;
                Second %= 60;
            }
            if (Minute >= 60) {
                Hour++;
                Minute %= 60;
            }
        }
    }
}
