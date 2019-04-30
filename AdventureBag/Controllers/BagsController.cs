using Microsoft.AspNetCore.Mvc;
using Adventure;
using System.Collections.Generic;

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

  }
}
