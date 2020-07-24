using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 100, 72720 );
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    public void OrderConstructor_CreatesInstanceOfOrderWithAllRequirements_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 100, 72720 );
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      Order newOrder1 = new Order("testTitle", "testDescription", 100, 72720);
      Order newOrder2 = new Order("testTitle2", "testDescription2", 200, 22720);
      Order newOrder3 = new Order("testTitle3", "testDescription3", 300, 32720);
      List<Order> newList = new List<Order> { newOrder1, newOrder2, newOrder3 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      Order newOrder1 = new Order("testTitle", "testDescription", 100, 72720);
      Order newOrder2 = new Order("testTitle2", "testDescription2", 200, 22720);
      Order newOrder3 = new Order("testTitle3", "testDescription3", 300, 32720);
      int result = newOrder1.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      Order newOrder1 = new Order("testTitle", "testDescription", 100, 72720);
      Order newOrder2 = new Order("testTitle2", "testDescription2", 200, 22720);
      Order newOrder3 = new Order("testTitle3", "testDescription3", 300, 32720);
      Order result = Order.Find(3);
      Assert.AreEqual(newOrder3, result);
    }

    [TestMethod]
    public void DeleteOrder_OrdersCanBeDeleted_Deleted()
    {
      Order newOrder1 = new Order("testTitle", "testDescription", 100, 72720);
      Order newOrder2 = new Order("testTitle2", "testDescription2", 200, 22720);
      Order newOrder3 = new Order("testTitle3", "testDescription3", 300, 32720);
      Order.DeleteOrder(newOrder2);
      CollectionAssert.DoesNotContain(Order.GetAll(), newOrder2);
    }

  
  }
}