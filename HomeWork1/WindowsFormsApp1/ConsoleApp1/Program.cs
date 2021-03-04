using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个数字：");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("请输入一个运算符：");
            char c = Char.Parse(Console.ReadLine());
            Console.Write("请输入第二个数字：");
            double num2 = Double.Parse(Console.ReadLine());
            double result = 0;
            switch (c)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("除数不能为0");
                    else
                        result = num1 / num2;
                    break;
                case '%': result = num1 % num2; break;
            }
            Console.WriteLine("结果为：{0}", result);
            return;
        }
    }
}
