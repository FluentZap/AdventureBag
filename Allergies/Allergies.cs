using System;
using System.Collections.Generic;

//This class will take arguments flags for Allergies and store in a single number then return them as a list of Allergies

//Mathew Method
//Todd Test
//Make a list of Allergies

//Mathew Test
//Todd Method
//Add Allergie to list


//Mathew Test
//Todd Method
//Return list as a List<String> taken from a dictionary of discriptions


namespace Allergies
{

  public enum Listof_Allergies : byte
  {
    eggs  = 0b0000_0001,
    peanuts = 0b0000_0010,
    shellfish = 0b0000_0100,
    strawberries = 0b0000_1000,
    tomatoes = 0b0001_0000,
    chocolate = 0b0010_0000,
    pollen = 0b0100_0000,
    cats = 0b1000_0000
  }


  public class AllergiesTest
  {
    public byte number;

    public AllergiesTest(byte num)
    {
      number = num;
    }

    public bool IsAllergic(Listof_Allergies allergie)
    {
      byte bitCheck = (byte)allergie;
      return (number & bitCheck) != 0;
    }

  }

}
