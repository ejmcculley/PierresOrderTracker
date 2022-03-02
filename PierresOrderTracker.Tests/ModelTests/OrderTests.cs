using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrderTracker.Models;
using System;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  
  public class OrderTests
  {
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
  }
}