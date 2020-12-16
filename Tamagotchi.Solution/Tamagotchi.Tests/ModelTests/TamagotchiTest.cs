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
      Assert.AreEqual("john", newPet.Name);

    }
  }
}
