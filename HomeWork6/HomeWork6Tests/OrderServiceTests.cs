using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Tests
{
    
    [TestClass()]
    public class OrderServiceTests
    {
        public OrderService orderService = new OrderService();
        List<Order> ordersResult = new List<Order>();

        private static Order order1 = new Order("1", "1", "1", "1");
        private static Order order2 = new Order("2", "2", "2", "2");
        private static Order order3 = new Order("3", "3", "3", "3");
        private static Order order4 = new Order("1", "3", "4", "4");

        static OrderDetails good1 = new OrderDetails("apple", 3.6, 1);//3.6
        static OrderDetails good2 = new OrderDetails("banana", 2, 5);//10
        static OrderDetails good3 = new OrderDetails("pear", 1.6, 4);//6.4

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)        
        {
            order1.AddOneDetail(good1);

            order2.AddOneDetail(good2);
            order2.AddOneDetail(good3);

            order3.AddOneDetail(good3);
        }

        [TestInitialize()]
        public void ClearList()
        {
            orderService.orders.Clear();
            ordersResult.Clear();
            orderService.AddOneOrder(order2);
            orderService.AddOneOrder(order1);
            orderService.AddOneOrder(order3);
        }

        [TestMethod()]
        public void AddOneOrderTest()
        {
            ordersResult.Add(order2);
            ordersResult.Add(order1);
            ordersResult.Add(order3);
            CollectionAssert.Equals(orderService.orders, ordersResult);
        }

        //[TestMethod()]
        //public void DisplayOrdersTest()
        //{
        //    Assert.Fail();
        //}
        
        [TestMethod()]
        public void DeleteOneOrderTest()
        {
            orderService.DeleteOneOrder(order1.ID);
            ordersResult.Add(order2);
            ordersResult.Add(order3);
            CollectionAssert.Equals(orderService.orders, ordersResult);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            
            orderService.UpdateOrder(order1.ID, order4);

            ordersResult.Add(order4);
            ordersResult.Add(order2);
            ordersResult.Add(order3);
            CollectionAssert.Equals(orderService.orders, ordersResult);
        }

        [TestMethod()]
        public void SearchByIdTest()
        {
            List<Order> query = orderService.SearchById(order2.ID);
            ordersResult.Add(order2);
            CollectionAssert.Equals(orderService.orders, ordersResult);
        }

        [TestMethod()]
        public void SearchByGoodNameTest()
        {
            List<Order> query = orderService.SearchByGoodName("pear");
            ordersResult.Add(order2);
            ordersResult.Add(order3);
            CollectionAssert.Equals(query, ordersResult);
        }

        [TestMethod()]
        public void SearchByTotalPriceTest()
        {
            List<Order> query = orderService.SearchByTotalPrice(3.6);
            ordersResult.Add(order1);
            CollectionAssert.Equals(query, ordersResult);
        }

        [TestMethod()]
        public void SearchBySenderNameTest()
        {
            List<Order> query = orderService.SearchBySenderName("1");
            ordersResult.Add(order1);
            CollectionAssert.Equals(query, ordersResult);
        }

        [TestMethod()]
        public void SortTest()
        {
            List<Order> query = orderService.Sort();
            Order[] orderRusultTemp = { order1, order2, order3 };
            CollectionAssert.AreEqual(query.ToArray(), orderRusultTemp);
        }

        [TestMethod()]
        public void ExportTest()
        {
            orderService.Export();
        }

        [TestMethod()]
        public void ImportTest()
        {
            orderService.Import();
        }
    }
}