using Microsoft.AspNetCore.Mvc;
using Adventure;
using System.Collections.Generic;
using System;

namespace Adventure.Controllers
{
  public class NoticeController : Controller
  {
    [HttpGet("/noticeboard")]
    public ActionResult Index()
    {

      return View(AdventureTime.notice.GetAll());
    }

    [HttpPost("/addnotice")]
    public ActionResult CreateNotice(string title, string description, string reward, string postedby, string expiration)
    {
      NoticeItem notice = new NoticeItem();
      notice.Title = title;			
      //{Title: title, Body: description, Reward: reward, PostedBy: postedby, Expiration: expiration}
      AdventureTime.notice.AddNotice(notice);

      return RedirectToAction("Index");
    }
  }
}
