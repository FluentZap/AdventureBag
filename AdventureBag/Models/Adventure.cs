using System;
using System.Collections.Generic;


namespace Adventure
{

  public static class AdventureTime
  {
    public static Bag adventureBag;
    public static Shop shop;


    static AdventureTime()
    {
      adventureBag = new Bag();
      shop = new Shop();

    }

  }


}
