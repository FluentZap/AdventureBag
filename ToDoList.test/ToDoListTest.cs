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
      Assert.AreEqual(1, bag.GetItem(Listof_Items.LongSword));
    }

    

  }



}
