using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tamagotchi.Models;


namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetsTests
  {
    [TestMethod]
    public void Pet_CreateAnInstanceOfPet_Pet()
    {
      
      // Act
      Pet testPet = new Pet("Pablo");
      //Assert
      Assert.AreEqual(typeof(Pet), testPet.GetType());
    }

    [TestMethod]
    public void Pet_GetNameOfPet_String()
    {
      //arrange
      Pet newPet = new Pet("Pablo");
      
      //Act
      Assert.AreEqual("Pablo", newPet.Name);
    }
    [TestMethod]
    public void Pet_CreatesPetWithProperties_Pet()
    {
      Pet newPet = new Pet("Pablo");
      Assert.AreEqual(10, newPet.Food);
      Assert.AreEqual(5, newPet.Attention);
      Assert.AreEqual(15, newPet.Rest);
      Assert.AreEqual(10, newPet.Hygiene);   
    }
  }
}
