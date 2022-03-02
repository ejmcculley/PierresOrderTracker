namespace PierresOrderTracker.Models
{
  public class Vendor
  {
   public string Name { get; set; } 
   public string Address { get; set; } 
   public string Email { get; set; } 
   public string Phone { get; set; } 
   public string Description { get; set; } 
   
   public Vendor(string vendorName, string vendorAddress, string vendorEmail, string vendorPhone, string vendorDescription)
   {
     Name = vendorName;
     Address = vendorAddress;
     Email = vendorEmail;
     Phone = vendorPhone;
     Description = vendorDescription;
   }
  }
}