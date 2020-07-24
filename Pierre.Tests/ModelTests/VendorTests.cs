using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class VendorTest 
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testName", "testDescription");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

   
  }
}