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
        //添加订单
        public void AddOneOrder(Order order)
        {         
            using(var db = new OrderContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            orders.Add(order);//原来的，此orderService对象添加一个order
        }
        //删除订单
        public void DeleteOneOrder(int IDDelete)
        {
            //数据库
            using(var context = new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(p => p.orderId == IDDelete);
                if(order!=null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            //老版本
            //for (int i = 0; i < orders.Count; i++)
            //{
            //    if (orders[i].orderId == IDDelete)
            //    {
            //        orders.Remove(orders[i]);
            //        return;
            //    }
            //}
            //throw new ArgumentException("不存在该orderId的订单");
        }

        public void UpdateOrder(int IDUpdate, Order newOrder)
        {
            DeleteOneOrder(IDUpdate);
            newOrder.orderId = IDUpdate;
            AddOneOrder(newOrder);
            Order.count--;
        }
        public List<Order> SearchById(int id)
        {
            //数据库
            using(var context = new OrderContext())
            {
                var order = context.Orders.Where(o => o.orderId == id);
                if (order != null)
                    return order.ToList();
                return null;
            }
            //老版本
            //var query = orders.Where(
            //    o => o.orderId == id);
            //return query.ToList();
        }
        public List<Order> SearchByGoodName(string goodname)
        {
            //数据库
            using(var context = new OrderContext())
            {
                var order = context.Orders.Where(o => o.Goods.Any(d => d.GoodName == goodname));
                return order.ToList();
            }
            //老版本
            //var query = orders.Where(
            //    o => o.Goods.Any(d => d.GoodName == goodname));
            //return query.ToList();
        }
        public List<Order> SearchByTotalPrice(double price)
        {
            //数据库
            using(var context = new OrderContext())
            {
                var order = context.Orders.Where(o => o.CostSum == price);
                return order.ToList();
            }
            //老版本
            //var query = orders.Where(
            //    o => o.CostSum == price);
            //return query.ToList();
        }
        public List<Order> SearchBySenderName(string sender)
        {
            using(var context = new OrderContext())
            {
                var order = context.Orders.Where(o => o.Sender == sender);
                return order.ToList();
            }
            //var query = orders.Where(
            //    o => o.Sender == sender);
            //return query.ToList();
        }
        public void Sort()
        {
            for (int i = 0; i < orders.Count - 1; i++)
            {
                for (int j = 0; j < orders.Count - i - 1; j++)
                {
                    if (orders[j].orderId > orders[j + 1].orderId)
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
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            //using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            //{
            //    xmlSerializer.Serialize(fs, orders);
            //}
        }

        public void Import()
        {
            using(var context = new OrderContext())
            {
                orders = context.Orders.ToList();
            }
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            //using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            //{
            //    orders = (List<Order>)xmlSerializer.Deserialize(fs);

            //}
        }
    }
}
