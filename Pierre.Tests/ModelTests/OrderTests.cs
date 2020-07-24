using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Order.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

  
  }
}