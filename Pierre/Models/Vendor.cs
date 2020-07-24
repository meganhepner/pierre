using System.Collections.Generic;

namespace Pierre.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _vendors = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendors.Add(this);
    }

    public static List<Vendor> GetAll()
    {

    }
    
  }
}