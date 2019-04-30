using System;
using System.Collections.Generic;

namespace Adventure
{

  public class Shop
  {


  static Shop()
  {
    Random rnd = new Random();
    int items = Enum.GetNames(typeof(Listof_Items)).Length;
    for (int i = 0; i < 30; i++) {
      AddItem((Listof_Items)rnd.Next(0, items), 1);
    }  
  }


    static List<BagItem> _Items = new List<BagItem>();

    public static void AddItem(Listof_Items name, int quanity)
    {
      for (int i = 0; i < _Items.Count; i++)
      {
        if (_Items[i].Name == name)
        {
          _Items[i].Quanity += quanity;
          return;
        }
      }
      _Items.Add(new BagItem(name, quanity));
    }

    public static bool GetItem(Listof_Items name)
    {
      for (int i = 0; i < _Items.Count; i++)
      {
        if (_Items[i].Name == name)
        {
          RemoveItems(name, 1);
          return true;
        }
      }
      return false;
    }

    public static List<BagItem> GetAllItems()
    {
      return _Items;
    }

    private static void RemoveItems(Listof_Items name, int quanity)
    {
      for (int i = 0; i < _Items.Count; i++)
      {
        if (_Items[i].Name == name)
        {
          _Items[i].Quanity -= quanity;
          if (_Items[i].Quanity <= 0)
          _Items.Remove(_Items[i]);
          return;
        }
      }
    }

    public static Listof_Items GetRandomItem()
    {
      Random rand = new Random();

      int totalItems = 0;
      foreach(BagItem item in _Items)
      {
        totalItems += item.Quanity;
      }
      if (totalItems > 0)
      {
        int selectedItem = rand.Next(1, totalItems);

        foreach(BagItem item in _Items)
        {
          for (int i = 0; i < item.Quanity; i++) {
            selectedItem--;
            if (selectedItem == 0)
            {
              RemoveItems(item.Name, 1);
              return item.Name;
            }
          }
        }
      }
      return Listof_Items.Nothing;
    }
  }
}
