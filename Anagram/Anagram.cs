using System;
using System.Collections.Generic;



//    Mathew Test/Todd Method
//Create a class and pass in the keyword *DONE*
//    Todd Test/Mathew Method
//Can use a method to add search words, do not add duplicate words store in a List<String>
//    Mathew Test/Todd Method
//Reture a list of the keyword and all words that are anagrams of it
namespace Anagram
{
  public class Anagram
  {
    string KeyWord;

    List<string> WordList = new List<string>();

    public Anagram(string keyWord)
    {
      KeyWord = keyWord;
    }

    public string GetKeyWord()
    {
      return KeyWord;
    }

    public void AddWord(string word)
    {
      foreach(string item in WordList)
      {
        if (item == word) {
          return;
        }
      }
      WordList.Add(word);
    }

    public List<string> GetList()
    {
      return WordList;
    }

    public List<string> GetAnagrams()
    {
      List<string> list = new List<string>();

      foreach(string item in WordList)
      {
        if (item.Length == KeyWord.Length)
        {
          char[] sortedKeyWord = KeyWord.ToCharArray();
          char[] sortedListWord = item.ToCharArray();
          Array.Sort(sortedKeyWord);
          Array.Sort(sortedListWord);
          bool inNotAEqual = false;
          for (int i = 0; i < sortedKeyWord.Length; i++) {
            if (sortedListWord[i] != sortedKeyWord[i])
            {
              inNotAEqual = true;
            }
          }
          if (inNotAEqual == false)
          {
            list.Add(item);
          }

        }
      }
      return list;
    }
  }
}
