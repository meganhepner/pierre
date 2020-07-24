using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class OrderTest 
  {

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

  
  }
}