using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(-1, -1, -1.5);
            Rectangle rectangle = new Rectangle(3, 4);
            Square square = new Square(5);
//            bool flag = triangle.Judge();
//            bool flag = rectangle.Judge();
            bool flag = square.Judge();
            if(flag==true)
            {
                Console.WriteLine("该形状合法！");
                Console.Write("该形状面积为：");
                Console.WriteLine(square.Area());
            }
            else
            {
                Console.WriteLine("该形状不合法...");
            }
            
            

        }
    }
}
