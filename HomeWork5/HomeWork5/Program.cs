using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            int num = 3;//订单总数
            //添加订单
            for(int i=0;i<num;i++)
            {
                orderService.AddOneOrder();
            }
            //删除订单
            Console.Clear();
            orderService.DeleteOneOrder();
            Console.Clear();
            orderService.DisplayOrders();

            //修改订单
            Console.Clear();
            orderService.ModifyOrder();
            Console.Clear();
            orderService.DisplayOrders();

            //查询订单
            Console.Clear();
            orderService.SearchOrder();
        }
    }
}
