using System.Collections.Generic;

namespace PierresOrderTracker.Models
{
  public class Order
  {
    public int BreadCount { get; set; }
    public int PastryCount { get; set; }
    // public int Id { get; }
    // private static List<Order> _instances = new Order<Order> { };

    public Order(int breadCount, int pastryCount)
    {
      BreadCount = breadCount;
      PastryCount = pastryCount;
      // _instances.Add(this);
      // Id = _instances.Count;
    }
  }
}