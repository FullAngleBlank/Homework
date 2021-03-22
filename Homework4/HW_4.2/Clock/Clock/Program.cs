using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        public static void Main(string[] args)
        {
                Clock clock = new Clock();
                Console.WriteLine("请设置钟初始时间：");
                Console.WriteLine("StartHour: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("StartMinute: ");
                int minutes = int.Parse(Console.ReadLine());
                Console.WriteLine("StartSecond: ");
                int seconds = int.Parse(Console.ReadLine());
                clock.SetTime(hours, minutes, seconds);
            


                Console.WriteLine("请设置闹钟时间：");
                Console.WriteLine("AlarmHour: ");
                hours = int.Parse(Console.ReadLine());
                Console.WriteLine("AlarmMinute: ");
                minutes = int.Parse(Console.ReadLine());
                Console.WriteLine("AlarmSecond: ");
                seconds = int.Parse(Console.ReadLine());
                clock.SetAlarm(hours, minutes, seconds);
                clock.Tick += Tick;
                clock.Alarm += Alarm;

                clock.Start();

                Console.ReadKey();
        }

        public static void Tick()
        {
            Console.WriteLine("Tick....");
        }

        public static void Alarm()
        {
            Console.WriteLine("Ding~~~");
        }

    }
}
