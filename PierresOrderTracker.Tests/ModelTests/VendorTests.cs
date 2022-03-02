using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor()
    {
      Vendor newVendor = new Vendor("name", "address", "email", "phone", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}