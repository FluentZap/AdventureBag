using System;
using System.Collections.Generic;
//Put items into a bag and get them out, if dulplicate items are added it will combine them.

//Add item to list
//Check the list for an Item
//Take an item from the bag
//Combine multiple items into quanity
//View items in the bag
//Get a random item from the bag based on quanity of items
//Hole in the bag loose random items
//Have a puch for a specific item in the bag

namespace AdventureBag
{

  public enum Listof_Items
  {
    Nothing,
    Dagger,
    ShortSword,
    LongSword,
    SmallHealthPotion,
    LargeHealthPotion,
    EmptyBottle,
    Mushrooms,
    TwigOfWood,
    LogOfWood,
    IronOre,
    GoldOre,
    IronIngot,
    GoldIngot


  }



  public class BagItem
  {
    public Listof_Items Name;
    public int Quanity;

    public BagItem(Listof_Items name, int quanity)
    {
      Name = name;
      Quanity = quanity;
    }
  }



  public class Bag
  {
    List<BagItem> _Items = new List<BagItem>();

    public void AddItem(Listof_Items name, int quanity)
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

    public int CheckForItem(Listof_Items name)
    {
      foreach(BagItem item in _Items)
      {
        if (item.Name == name)
        {
          return item.Quanity;
        }
      }
      return 0;
    }

    public bool GetItem(Listof_Items name)
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

    public List<BagItem> GetAllItems()
    {
      return _Items;
    }

    private void RemoveItems(Listof_Items name, int quanity)
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

    public Listof_Items GetRandomItem()
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
