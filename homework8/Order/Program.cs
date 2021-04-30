using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            int num = 3;//订单总数
            //添加订单
            for(int i=0;i<num;i++)
            {
                Console.WriteLine("请输入发货人姓名：");
                string sender = Console.ReadLine();
                Console.WriteLine("请输入收货人姓名：");
                string receiver = Console.ReadLine();
                Console.WriteLine("请输入发货地址：");
                string senderAddress = Console.ReadLine();
                Console.WriteLine("请输入收货地址：");
                string receiveAddress = Console.ReadLine();
                Console.WriteLine("请输入要添加的商品种数");
                int numOfGoods = Int32.Parse(Console.ReadLine());
                orderService.AddOneOrder(sender, receiver, senderAddress, receiveAddress, numOfGoods);
            }
            //删除订单
            Console.Clear();
            orderService.DisplayOrders();
            Console.WriteLine("请输入你要删除的订单ID：");
            int IDDelete = Int32.Parse(Console.ReadLine());
            orderService.DeleteOneOrder(IDDelete);
            Console.Clear();
            orderService.DisplayOrders();

            //修改订单
            Console.Clear();
            orderService.DisplayOrders();
            Console.WriteLine("请输入你要修改的订单ID：");
            int IDModify = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请问您想要修改该订单的第几条订单明细？");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入要修改的项目：(A、商品名称 B、商品单价 C、商品数量)");
            char ModifyProject = Char.Parse(Console.ReadLine());            
            Console.WriteLine("您要修改为：");
            string ValueAfterModify = Console.ReadLine();
            orderService.ModifyOrder(IDModify,number, ModifyProject, ValueAfterModify);
            Console.Clear();
            orderService.DisplayOrders();

            //查询订单
            Console.Clear();
            Console.WriteLine("请问根据什么查询订单？");
            Console.WriteLine("A.订单号  B.商品名称  C.发件人  D.订单金额");
            char choice = Char.Parse(Console.ReadLine());
            Console.WriteLine("输入要查询的项目信息：");
            string item = Console.ReadLine();
            var query = orderService.SearchOrder(choice,item);
            foreach (var orderDisp in query)
            {
                Console.WriteLine(orderDisp.ToString());
            }
        }
    }
}
