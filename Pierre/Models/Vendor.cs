using System.Collections.Generic;

namespace Pierre.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _vendors = new List<Vendor> {};
    public int Id { get; }
    private static int _currentId = 1;

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendors.Add(this);
      Id = _currentId;
      _currentId ++;
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static void ClearCurrentId()
    {
      _currentId = 1;
    }

    public static Vendor Find(int searchId)
    {
      return _vendors[searchId -1];
    }

    public static void DeleteVendor(Vendor vendorName)
    {
      _vendors.Remove(vendorName);
    }
    
  }
}