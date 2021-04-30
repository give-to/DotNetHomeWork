using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork5
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        
        public void AddOneOrder(string sender, string receiver, string senderAddress, string receiveAddress, int numOfGoods)
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();            
            for (int i=0;i<numOfGoods;i++)
            {
                OrderDetails orderDetailsTemp = null;
                AddOneGood(ref orderDetailsTemp);
                orderDetails.Add(orderDetailsTemp);
            }
            orders.Add(new Order(sender, receiver, senderAddress, receiveAddress, orderDetails));

        }

        private void AddOneGood(ref OrderDetails orderDetailsTemp)
        {
            Console.WriteLine("请输入商品名称：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入商品单价：");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入购买的商品数量：");
            int num = Int32.Parse(Console.ReadLine());
            orderDetailsTemp = new OrderDetails(name, price, num);
            
        }
        public void DisplayOrders()
        {
            for (int i=0;i<orders.Count;i++)
            {
                Console.WriteLine(orders[i].ToString());
            }
        }
        public void DeleteOneOrder(int IDDelete)
        {            
            for(int i=0;i<orders.Count;i++)
            {
                if(orders[i].ID==IDDelete)
                {
                    orders.Remove(orders[i]);
                    return;
                }
            }
            throw new ArgumentException("不存在该ID的订单");
        }

        public void ModifyOrder(int IDModify, int num, char ModifyProject, string ValueAfterModify)
        {
            
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].ID == IDModify)
                {
                    switch (ModifyProject)
                    {
                        case 'A':
                            orders[i].Goods[num-1].GoodName = ValueAfterModify;
                            break;
                        case 'B':
                            orders[i].Goods[num-1].CostPerGood = Double.Parse(ValueAfterModify);
                            break;
                        case 'C':
                            orders[i].Goods[num - 1].NumOfGood = Int32.Parse(ValueAfterModify);
                            break;
                        default:
                            throw new ArgumentException("不存在该项目");                            
                    }                    
                    return;
                }
            }
            throw new ArgumentException("不存在该ID的订单");
        }

        public IEnumerable<Order> SearchOrder(char choice,string item)
        {            
            switch (choice)
            {
                case 'A':
                    int searchID = Int32.Parse(item);
                    var query1 = from o in orders
                                where o.ID == searchID
                                 orderby o.CostSum
                                 select o;
                    return query1;

                case 'B':
                    string searchGoodName = item;
                    var query2 = from o in orders
                                 from o2 in o.Goods
                                 where o2.GoodName == searchGoodName
                                 orderby o.CostSum
                                 select o;
                    return query2;
                case 'C':
                    string searchSenderName = item;
                    var query3 = from o in orders
                                 where o.Sender == searchSenderName
                                 orderby o.CostSum
                                 select o;
                    return query3;
                case 'D':                    
                    var query4 = from o in orders                                 
                                 orderby o.CostSum
                                 select o;                    
                    return query4;
                default:
                    throw new ApplicationException("不存在该项目");
            }
        }
        //lamda表达式不太会用
        //public delegate bool Func(double x, double y);
        public void Sort()
        {
            for(int i=0;i<orders.Count-1;i++)
            {
                for (int j=0;j<orders.Count-i-1;j++)
                {
                    if(orders[j].ID>orders[j+1].ID)
                    {
                        Order orderTemp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = orderTemp;
                    }
                }
            }
        }

        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml",FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream("s.xml",FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);

            }
        }
    }
}
