using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testName", "testDescription");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      Vendor newVendor1 = new Vendor("testName1", "testDescription1");
      Vendor newVendor2 = new Vendor("testName2", "testDescription2");
      Vendor newVendor3 = new Vendor("testName3", "testDescription3");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2, newVendor3 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string name1 = "ISK";
      string description1 = "restaurant";
      string name2 = "FM";
      string description2 = "grocery";
      string name3 = "downtown";
      string description3 = "market";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor newVendor3 = new Vendor(name3, description3);
      int result = newVendor2.Id;
      Assert.AreEqual(2, result);
    }

   
  }
}