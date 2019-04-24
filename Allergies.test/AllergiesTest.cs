using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;
using System;

namespace Allergies.Tests
{

  [TestClass]
  public class TestAddItems
  {

    //Contructor adds Allergies to the number
    //IsAlergic returns bool if the number contains the Allergie

    [TestMethod]
    public void TestAddAllergiesToList()
    {
      AllergiesTest allergyList = new AllergiesTest(
            (byte)Listof_Allergies.eggs |
            (byte)Listof_Allergies.tomatoes |
            (byte)Listof_Allergies.pollen);

            Assert.IsTrue(allergyList.IsAllergic(Listof_Allergies.eggs));
            Assert.IsTrue(allergyList.IsAllergic(Listof_Allergies.tomatoes));
            Assert.IsTrue(allergyList.IsAllergic(Listof_Allergies.pollen));
            Assert.IsFalse(allergyList.IsAllergic(Listof_Allergies.shellfish));
    }

  }
}
