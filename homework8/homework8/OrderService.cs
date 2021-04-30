using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework8
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        
        public List<Order> Orders { get { return orders; } }
        public void AddOneOrder(Order order)
        {            
            orders.Add(order);
        }
        public void DisplayOrders()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine(orders[i].ToString());
            }
        }
        public void DeleteOneOrder(int IDDelete)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].ID == IDDelete)
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
                            orders[i].Goods[num - 1].GoodName = ValueAfterModify;
                            break;
                        case 'B':
                            orders[i].Goods[num - 1].CostPerGood = Double.Parse(ValueAfterModify);
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

        public IEnumerable<Order> SearchOrder(char choice, string item)
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
        public void Sort()
        {
            for (int i = 0; i < orders.Count - 1; i++)
            {
                for (int j = 0; j < orders.Count - i - 1; j++)
                {
                    if (orders[j].ID > orders[j + 1].ID)
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
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);

            }
        }
    }
}
