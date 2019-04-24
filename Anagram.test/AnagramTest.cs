using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
  public class TestMethods
  {
    [TestMethod]
    public void TestKeywordSave()
    {
      Anagram anagram = new Anagram("bread");
      Assert.AreEqual("bread", anagram.GetKeyWord());
    }

    [TestMethod]
    public void TestWordList()
    {
      Anagram anagram = new Anagram("bread");
      anagram.AddWord("beard");
      Assert.AreEqual(1, anagram.GetList().Count);
      anagram.AddWord("debra");
      Assert.AreEqual(2, anagram.GetList().Count);
      anagram.AddWord("debra");
      Assert.AreEqual(2, anagram.GetList().Count);
    }
    [TestMethod]
    public void ReturnWordList()
    {
      Anagram anagram = new Anagram("bread");
      anagram.AddWord("beard");
      anagram.AddWord("debra");
      anagram.AddWord("happy");
      anagram.AddWord("notbread");

      List<string> anagrams = anagram.GetAnagrams();

      Assert.IsTrue(ListContains("beard", anagrams));
      Assert.IsTrue(ListContains("debra", anagrams));
      Assert.IsFalse(ListContains("happy", anagrams));
      Assert.IsFalse(ListContains("notbread", anagrams));
    }

    public bool ListContains(string word, List<string> wordList)
    {
      foreach(string item in wordList)
      {
        if (item == word)
        {
            return true;
        }
      }
      return false;
    }
  }
}
