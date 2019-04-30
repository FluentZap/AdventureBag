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
      List<BagItem> allItems = AdventureTime.adventureBag.GetAllItems();
      Bag.AddItem(Listof_Items.LongSword, 1);
      return View(allItems);
    }

  }
}
