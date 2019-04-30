using System;
using System.Collections.Generic;


namespace Adventure
{
  public class NoticeItem
  {
    public string Title {get; set;}
    public string Body {get; set;}
    public string Reward {get; set;}
    public string PostedBy {get; set;}
    public string Expiration {get; set;}
  }

  public class NoticeBoard
  {
    List<NoticeItem> _noticeList = new List<NoticeItem>();

    public void AddNotice(NoticeItem notice)
    {
      _noticeList.Add(notice);
    }

    public List<NoticeItem> GetAll()
    {
      return _noticeList;
    }


  }
}
