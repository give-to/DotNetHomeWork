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
            int numOrder = 1;//订单总数
            //添加订单
            for(int i=0;i< numOrder; i++)
            {
                orderService.AddOneOrder(CreateOneOrder());
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
            Console.WriteLine("您要修改为：");
            orderService.UpdateOrder(IDModify, CreateOneOrder());
            Console.Clear();
            orderService.DisplayOrders();
            
            //查询订单
            List<Order> query;
            Console.Clear();
            Console.WriteLine("请问根据什么查询订单？");
            Console.WriteLine("A.订单号  B.商品名称  C.发件人  D.订单金额");
            char choice = Char.Parse(Console.ReadLine());
            switch (choice)
            {
                case 'A':
                    Console.WriteLine("请输入要查询的订单号：");
                    int id = Int32.Parse(Console.ReadLine());
                    query = orderService.SearchById(id);
                    break;
                case 'B':
                    Console.WriteLine("请输入要查询的商品名称：");
                    string goodName = Console.ReadLine();
                    query = orderService.SearchByGoodName(goodName);
                    break;
                case 'C':
                    Console.WriteLine("请输入要查询的发件人：");
                    string sender = Console.ReadLine();
                    query = orderService.SearchBySenderName(sender);
                    break;
                case 'D':
                    Console.WriteLine("请输入要查询的订单金额：");
                    double priceTotal = Double.Parse(Console.ReadLine());
                    query = orderService.SearchByTotalPrice(priceTotal);
                    break;
                default:
                    throw new ApplicationException("不存在此查询选项");
                    return;
            }
            foreach (Order orderDisp in query)
            {
                Console.WriteLine(orderDisp.ToString());
            }
        }

        public static Order CreateOneOrder()
        {
            Console.WriteLine("请输入发货人姓名：");
            string sender = Console.ReadLine();
            Console.WriteLine("请输入收货人姓名：");
            string receiver = Console.ReadLine();
            Console.WriteLine("请输入发货地址：");
            string senderAddress = Console.ReadLine();
            Console.WriteLine("请输入收货地址：");
            string receiveAddress = Console.ReadLine();

            Order order = new Order(sender, receiver, senderAddress, receiveAddress);

            Console.WriteLine("请输入要添加的商品种数:");
            int numOfGoods = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < numOfGoods; j++)
            {
                Console.WriteLine("请输入商品名称：");
                string goodName = Console.ReadLine();
                Console.WriteLine("请输入商品数量：");
                int numDetails = Int32.Parse(Console.ReadLine());
                Console.WriteLine("请输入商品单价：");
                double priceDetail = Double.Parse(Console.ReadLine());
                order.AddOneDetail(goodName, priceDetail, numDetails);
            }
            return order;
        }
    }
}
