using Microsoft.AspNetCore.Mvc;
using Adventure;
using System.Collections.Generic;
using System;

namespace Adventure.Controllers
{
  public class BagsController : Controller
  {

    [HttpGet("/adventurebag")]
    public ActionResult Index ()
    {
      //List<BagItem> allItems = AdventureTime.adventureBag.GetAllItems();
      //AdventureTime.adventureBag.AddItem(Listof_Items.LongSword, 1);
      BagViewController bagview = new BagViewController();
      bagview.bag = AdventureTime.bag;
      bagview.shop = AdventureTime.shop;
      return View(bagview);
    }

    [HttpPost("/adventurebag")]
    public ActionResult ItemBuy()
    {
      Random rnd = new Random();
      int items = Enum.GetNames(typeof(Listof_Items)).Length;
      for (int i = 0; i < 1; i++) {
        AdventureTime.bag.AddItem((Listof_Items)rnd.Next(1, items), 1);
      }
      // AdventureTime.bag.AddItem(Listof_Items.LongSword, 1);
      return RedirectToAction("Index");
    }

    [HttpPost("/adventurebuy")]
    public ActionResult ItemBuy(string buyitem)
    {
      //Listof_Items myStatus;
      Enum.TryParse(buyitem, out Listof_Items myStatus);

      AdventureTime.bag.AddItem(myStatus, 1);
      return RedirectToAction("Index");
    }
  }
}
