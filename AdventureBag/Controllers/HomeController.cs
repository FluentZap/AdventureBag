using Microsoft.AspNetCore.Mvc;
using Adventure;
using System.Collections.Generic;
using System;

namespace Adventure.Controllers
{
  public class HomeController : Controller
  {


    [HttpGet("/")]
    public ActionResult Index()
    {
      // List<Item> allItems = Item.GetAll();
      // Console.WriteLine("Index Method");
      return View();
    }
  

  }
}
