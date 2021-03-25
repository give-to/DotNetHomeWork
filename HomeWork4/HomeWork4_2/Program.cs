using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Console.WriteLine("闹钟启动，滴答滴答...");
            Console.Write("请输入设置的闹钟时间(hh-mm-ss):");
            string alarmTime = Console.ReadLine();
            DateTime alarmDateTime = DateTime.ParseExact(alarmTime, "HH-m-s", System.Globalization.CultureInfo.CurrentCulture);
            clock.AlarmRun(alarmDateTime);
            //clock.Run();
            
            
        }
    }
}
