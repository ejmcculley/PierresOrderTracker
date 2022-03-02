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

    // [TestMethod]
    // public void FindVendor()
    // {
    //   //Arrange
    //   string name01 = "Billy Baker";
    //   string name02 = "Callies Cookies";
    //   Vendor newVendor1 = new Vendor(name01);
    //   Vendor newVendor2 = new Vendor(name02);

    //   //Act
    //   Vendor result = Vendor.Find(2);

    //   //Assert
    //   Assert.AreEqual(newVendor2, result);
    // }
  }
}