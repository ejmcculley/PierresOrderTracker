using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrderTracker.Models;
using System;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor()
    {
      Order newOrder = new Order("order description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription()
    {
      string orderDescription = "order description";
      Order newOrder = new Order(orderDescription);

      string result = newOrder.OrderDescription;

      Assert.AreEqual(orderDescription, result);
    }
    [TestMethod]
    public void SetOrderDescription()
    {
      string orderDescription = "order description";
      Order newOrder = new Order(orderDescription);

      string changedOrder = "changed order";
      newOrder.OrderDescription = changedOrder;
      string result = newOrder.OrderDescription;

      Assert.AreEqual(changedOrder, result);
    }
    [TestMethod]
    public void GetAllReturnsEmptyList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAllReturnsList()
    {
    string orderDescription01 = "3 loaves of bread";
    string orderDescription02 = "3 pastries";
    Order newOrder1 = new Order(orderDescription01);
    Order newOrder2 = new Order(orderDescription02);
    List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    List<Order> result = Order.GetAll();

    CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void FindOrder()
    {
      string orderDescription01 = "orderDescription01";
      string orderDescription02 = "orderDescription02";
      Order newOrder1 = new Order(orderDescription01);
      Order newOrder2 = new Order(orderDescription02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}