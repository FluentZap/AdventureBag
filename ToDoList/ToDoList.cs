using System;
using System.Collections.Generic;
//Put items into a bag and get them out, if dulplicate items are added it will combine them.

//Add item to list
//Check the list for an Item
//Combine multiple items into quanity
//View items in the bag
//Get a random item from the bag
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



  struct BagItem
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
       _Items.Add(new BagItem(name, quanity));
    }

    public int GetItem(Listof_Items name)
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



  }






}
