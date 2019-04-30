using Microsoft.AspNetCore.Mvc;
using Adventure.Models;
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

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return View();
      //return RedirectToAction("Index");
    }

  }
}
