using System.Collections.Generic;

namespace Pierre.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    private static int _currentId = 0;
    private static List<Order> _orders = new List<Order> {};

    public Order(string title, string description, int price, int date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _orders.Add(this);
      Id = _currentId;
      _currentId ++;
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orders[searchId -1];
    }

    public static void DeleteOrder(Order orderTitle)
    {
      
    }

  
  }
}
