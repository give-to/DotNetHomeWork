using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Order
    {
        private static int count = 0;

        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime PayTime { get; }
        private double CostSum { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public int ID { get; }
        public List<OrderDetails> Goods;

        public Order(string sender,string receiver,string senderAddress,string receiveAddress, List<OrderDetails> goods)
        {
            Sender = sender;
            Receiver = receiver;
            SenderAddress = senderAddress;
            ReceiverAddress = receiveAddress;
            PayTime = DateTime.Now;
            count++;
            ID = count;
            Goods = goods;
            foreach(OrderDetails orderDetails in goods)
            {
                CostSum += orderDetails.CostSum;
            }
        }
        
        public double GetRefreshCostSum()
        {
            CostSum = 0;
            foreach (OrderDetails orderDetails in Goods)
            {
                CostSum += orderDetails.CostSum;
            }
            return CostSum;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("订单ID：" +ID);
            str.Append('\n');
            str.Append("下单时间：" + PayTime + '\n');
            str.Append("用户：" + Sender + "-------->" + Receiver+'\n');
            str.Append("地址：" + SenderAddress + "-------->" + ReceiverAddress+ '\n');
            str.Append("订单明细：" + '\n');
            foreach (OrderDetails orderDetails in Goods)
            {
                str.Append(orderDetails.ToString());
            }
            str.Append("总价为：" + GetRefreshCostSum() + '\n');
            str.Append('\n');
            return str.ToString();                
        }
        
    }
}
