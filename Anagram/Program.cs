using System;
using System.Collections.Generic;

namespace Anagram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Anagram tester!");
      Console.Write("Please enter a keyword: ");
      string keyword = Console.ReadLine();
      Anagram ana = new Anagram(keyword);
      Console.WriteLine("Please enter the words to check vs the keyword");
      Console.WriteLine("When you are done enter /stop");
      string userInput = "";
      while(userInput != "/stop")
      {
        userInput = Console.ReadLine();
        ana.AddWord(userInput);
      }
      Console.WriteLine("The Anagrams of " + ana.GetKeyWord() + " are:");

      foreach (string item in ana.GetAnagrams()) {
        Console.WriteLine(item);
      }
    }
  }
}
