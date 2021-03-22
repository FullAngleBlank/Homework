using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;  //导入命名空间,类Thread就在此空间中
 

namespace Clock
{
    public delegate void ClockHandler();

    class Clock
    {
        public event ClockHandler Tick;
        public event ClockHandler Alarm;

        private Timer startTime;
        private Timer alarmTime;

        public Timer Time { get; set; }
        public Timer AlarmTime { get; set; }

        // 设置时间
        public void SetTime(int hour, int minute, int second)
        {
            startTime = new Timer(hour, minute, second);
        }

        // 设置闹钟
        public void SetAlarm(int hour, int minute, int second)
        {
            alarmTime = new Timer(hour, minute, second);

        }

        // 开启钟
        public void Start()
        {
            Console.WriteLine("Time Start!");

            while (true)
            {
                startTime.TimeGo();
                Tick();
                Thread.Sleep(1000); //延时1s

                if (Ring()) break;
            }
        }

        // 判断闹钟响铃
        private bool Ring()
        {
            if (startTime.Equals(alarmTime))
            {
                Alarm();
                Console.WriteLine($"时间到！现在的时间是：{startTime.Hour}时： {startTime.Minute}分： {startTime.Second}秒");
                return true;
            }
            return false;
        }
    }
}