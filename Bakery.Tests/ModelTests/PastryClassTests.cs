using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests;

[TestClass]
public class PastryTest
{
  [TestMethod]
  public void CreateListUpToInput()
  {
    // Arrange
    List<int> expectedList = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
    List<int> resultList = Pastry.ListOf(6);

    // Act & Assert
    CollectionAssert.AreEqual(expectedList, resultList);
  }
  [TestMethod]
  public void DeterminePastryTotal()
  {
    List<int> potentialPastries = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
    int expectedPastryTotal = 0;
    int actualTotal = Pastry.CalcTotal(potentialPastries, expectedPastryTotal);
    Assert.AreEqual(10, actualTotal);
  }
}


