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
      Order newOrder = new Order(3, 3);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}