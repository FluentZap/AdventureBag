using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureBag;

namespace ToDoList.Tests
{

  [TestClass]
  public class TestAddItems
  {
    [TestMethod]
    public void TestAddItemsToBag()
    {
      Bag bag = new Bag();
      bag.AddItem(Listof_Items.LongSword, 1);
      Assert.AreEqual(1, bag.CheckForItem(Listof_Items.LongSword));
    }
    [TestMethod]
    public void TestAddMultipleItemsToBag()
    {
      Bag bag = new Bag();
      bag.AddItem(Listof_Items.LongSword, 1);
      bag.AddItem(Listof_Items.LongSword, 1);
      Assert.AreEqual(2, bag.CheckForItem(Listof_Items.LongSword));
    }

    [TestMethod]
    public void TestCheckForItemInBag()
    {
      Bag bag = new Bag();
      bag.AddItem(Listof_Items.LongSword, 1);
      Assert.AreEqual(1, bag.CheckForItem(Listof_Items.LongSword));
    }

    [TestMethod]
    public void TestGetItemFromBag()
    {
      Bag bag = new Bag();
      bag.AddItem(Listof_Items.LongSword, 3);
      Assert.IsTrue(bag.GetItem(Listof_Items.LongSword));
      Assert.IsTrue(bag.GetItem(Listof_Items.LongSword));
      Assert.IsTrue(bag.GetItem(Listof_Items.LongSword));
      Assert.IsFalse(bag.GetItem(Listof_Items.LongSword));
    }


    [TestMethod]
    public void TestGetAllItemsFromBag()
    {
      Bag bag = new Bag();
      bag.AddItem(Listof_Items.LongSword, 1);
      bag.AddItem(Listof_Items.ShortSword, 1);
      var list = bag.GetAllItems();
      Assert.AreEqual(Listof_Items.LongSword, list[0].Name);
      Assert.AreEqual(1, list[0].Quanity);

      Assert.AreEqual(Listof_Items.ShortSword, list[1].Name);
      Assert.AreEqual(1, list[1].Quanity);
    }





    [TestMethod]
    public void TestGetRandomItemFromBag()
    {
      Bag bag = new Bag();
      bag.AddItem(Listof_Items.LongSword, 1);
      bag.AddItem(Listof_Items.ShortSword, 1);
      bag.AddItem(Listof_Items.LargeHealthPotion, 10);
      bag.AddItem(Listof_Items.SmallHealthPotion, 2);
      bag.AddItem(Listof_Items.Mushrooms, 1);
      bag.AddItem(Listof_Items.SmallHealthPotion, 4);
      bag.AddItem(Listof_Items.TwigOfWood, 7);
      bag.AddItem(Listof_Items.IronOre, 14);
      bag.AddItem(Listof_Items.LogOfWood, 12);

      bool foundItem = false;
      for (int i = 0; i < 49; i++)
      {
        var listOfItems = bag.GetAllItems();
        var takenItem = bag.GetRandomItem();

        foreach(Listof_Items item in listOfItems)
        {
          if (item.Name == takenItem) foundItem = true;
        }
        Assert.AreEqual(true, foundItem);
      }
      Assert.AreEqual(listOfItems.Nothing, bag.GetRandomItem());
    }
  }



}
