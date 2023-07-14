using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void CreateListUpToInput()
    {
      // Arrange
      List<int> expectedList = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
      List<int> resultList = Bread.ListOf(6);

      // Act & Assert
      CollectionAssert.AreEqual(expectedList, resultList);
    }
    [TestMethod]
    public void DetermineBreadTotal()
    {
      List<int> potentialBread = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
      int expectedTotal = 0;
      int actualTotal = Bread.CalcTotal(potentialBread, expectedTotal);
      Assert.AreEqual(20, actualTotal);
    }
  }
}