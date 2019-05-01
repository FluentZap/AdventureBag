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
      return RedirectToAction("Index");
    }


    [HttpPost("/adventurebuy")]
    public ActionResult Buy(string name, string city)
		{
			Console.WriteLine(name);
      Console.WriteLine(city);
      Random rnd = new Random();
      int items = Enum.GetNames(typeof(Listof_Items)).Length;
      for (int i = 0; i < 1; i++)
      {
          AdventureTime.bag.AddItem((Listof_Items)rnd.Next(1, items), 1);
      }      
      return RedirectToAction("Index");
    }

		[HttpGet("/adventuregetlist")]
		public string GetList()
		{			
			string items = "";			
			foreach(BagItem item in AdventureTime.bag.GetAllItems())
			{
				items +="<li>" + item.Quanity + " " + item.Name + "</li>";
			}			
			return items;
		}
		
	}
}
