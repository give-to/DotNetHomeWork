using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //整型list
            GenericList<int> genericList = new GenericList<int>();
            Random random = new Random();

            for(int i=0;i<10;i++)
            {
                genericList.Add(random.Next(0,10));
            }
            //show
            genericList.ForEach(Console.WriteLine);
            //求和
            int sum = 0;
            genericList.ForEach(x => sum += x);

            //求max
            int max = genericList.Head.Data;
            genericList.ForEach(
                x => 
                {
                    if (max < x)
                        max = x;
                }
            );

            //求min
            int min = genericList.Head.Data;
            genericList.ForEach(
                x =>
                {
                    if (x < min) min = x;
                }
            );

            Console.WriteLine($"sum:{sum}");
            Console.WriteLine($"max:{max}");
            Console.WriteLine($"min:{min}");

        }
    }
}
