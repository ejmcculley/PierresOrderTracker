using System.Collections.Generic;

namespace PierresOrderTracker.Models
{
  public class Vendor
  {
   private static List<Vendor> _instances = new List<Vendor> {};
   public string Name { get; set; } 
   public string Address { get; set; } 
   public string Email { get; set; } 
   public string Phone { get; set; } 
   public string Description { get; set; } 
   public int Id { get; }
   public List<Order> Orders { get; set; } 
   
   public Vendor(string vendorName, string vendorAddress, string vendorEmail, string vendorPhone, string vendorDescription)
   {
     Name = vendorName;
     Address = vendorAddress;
     Email = vendorEmail;
     Phone = vendorPhone;
     Description = vendorDescription;
     _instances.Add(this);
     Id = _instances.Count;
     Orders = new List<Order>{};
   }
   public static void ClearAll()
   {
     _instances.Clear();
   }
   public static List<Vendor> GetAll()
   {
     return _instances;
   }
   public static Vendor Find(int searchId)
   {
     return _instances[searchId-1];
   }
   public void AddOrder(Order orderDescription)
   {
     Orders.Add(orderDescription);
   }
  }
}