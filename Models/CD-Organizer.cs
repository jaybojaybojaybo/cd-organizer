using System;
using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class Album
  {
    private string _title;
    private int _price;
    private int _id;

    private static List<Album> _instances = new List<Album> {};

    public Album(string title, int price)
    {
      _title = title;
      _price = price;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string title)
    {
      _title = title;
    }

    public int GetPrice()
    {
        return _price;
    }

    public void SetPrice(int price)
    {
      _price = price;
    }

    public static List<Album> GetAll()
    {
      return _instances;
    }

    public static Album Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public int GetId()
    {
      return _id;
    }
  }
}
