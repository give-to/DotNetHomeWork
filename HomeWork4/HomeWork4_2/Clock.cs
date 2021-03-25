using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeWork4_2
{
    public delegate void TickHanlder();
    public delegate void AlarmHanlder(DateTime dataTime);
    public class Clock
    {
        public event TickHanlder Tick;
        public event AlarmHanlder Alarm;
        public void TimeFly()
        {
            Console.Write(". ");
            Thread.Sleep(1000);            
        }

        public void Run()
        {
            Tick();            
        }

        public void AlarmRemind(DateTime dataTime)
        {
            while(Math.Abs(dataTime.Ticks-DateTime.Now.Ticks)>10e7)//1tick=10e-7s
            {
                Run();
            }
            Console.WriteLine();
            Console.WriteLine("叮铃铃叮铃铃！！！闹钟响啦！！！");
            for(int i= 0;i<10;i++)//响铃后，再运行十秒钟
            {
                Run();
            }
            Console.WriteLine();
        }

        public void AlarmRun(DateTime dataTime)
        {
            Alarm(dataTime);
        }
        public Clock()
        {
            Tick += TimeFly;
            Alarm += AlarmRemind;
        }
    }
}
