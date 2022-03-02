using System.Collections.Generic;

namespace PierresOrderTracker.Models
{
  public class Order
  {
    public string OrderDescription { get; set; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string orderDescription)
    {
      OrderDescription = orderDescription;
      _instances.Add(this);
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    } 
  }
}