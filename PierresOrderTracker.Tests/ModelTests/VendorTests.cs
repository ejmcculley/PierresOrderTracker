using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrderTracker.Models;
using System;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor()
    {
      Vendor newVendor = new Vendor("name", "address", "email", "phone", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
    [TestMethod]
    public void GetVendorName()
    {
      string vendorName = "vendorName";
      Vendor newVendor = new Vendor(vendorName, "address", "email", "phone", "description");

      string result = newVendor.Name;

      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void GetVendorAddress()
    {
      string vendorAddress = "vendorAddress";
      Vendor newVendor = new Vendor("vendorName", vendorAddress, "email", "phone", "description");

      string result = newVendor.Address;

      Assert.AreEqual(vendorAddress, result);
    }
    [TestMethod]
    public void GetVendorEmail()
    {
      string vendorEmail = "vendorEmail";
      Vendor newVendor = new Vendor("vendorName", "vendorAddress", vendorEmail, "phone", "description");

      string result = newVendor.Email;

      Assert.AreEqual(vendorEmail, result);
    }
    [TestMethod]
    public void GetVendorPhone()
    {
      string vendorPhone = "vendorPhone";
      Vendor newVendor = new Vendor("vendorName", "vendorAddress", "vendorEmail", vendorPhone, "description");

      string result = newVendor.Phone;

      Assert.AreEqual(vendorPhone, result);
    }
    [TestMethod]
    public void GetVendorDescription()
    {
      string vendorDescription = "vendorDescription";
      Vendor newVendor = new Vendor("vendorName", "vendorAddress", "vendorEmail", "vendorPhone", vendorDescription);

      string result = newVendor.Description;

      Assert.AreEqual(vendorDescription, result);
    }
    [TestMethod]
    public void GetVendorId()
    {
      string vendorName = "vendorName";
      Vendor newVendor = new Vendor(vendorName, "vendorAddress", "vendorEmail", "vendorPhone", "vendorDescription");

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAllVendors()
    {
      string vendorName01 = "vendorName01";
      string vendorName02 = "vendorName02";
      Vendor newVendor1 = new Vendor(vendorName01, "vendorAddress", "vendorEmail", "vendorPhone", "vendorDescription");
      Vendor newVendor2 = new Vendor(vendorName02, "vendorAddress", "vendorEmail", "vendorPhone", "vendorDescription");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void FindVendor()
    {
      string vendorName01 = "vendorName01";
      string vendorName02 = "vendorName02";
      Vendor newVendor1 = new Vendor(vendorName01, "vendorAddress", "vendorEmail", "vendorPhone", "vendorDescription");
      Vendor newVendor2 = new Vendor(vendorName02, "vendorAddress", "vendorEmail", "vendorPhone", "vendorDescription");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrderToVendor()
    {
      string orderDescription = "order description";
      Order newOrder = new Order(orderDescription);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "vendorName";
      Vendor newVendor = new Vendor(vendorName, "vendorAddress", "vendorEmail", "vendorPhone", "vendorDescription");
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}