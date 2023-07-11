using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallChange.Models;
namespace SmallChange.Tests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]
        public void DivideByUserInput_PrintAmountOfCoins()
        {
            // Arrange
            Assert.AreEqual(Change.Break(50), "Your Change is: 2 quarters, 0 dimes, 0 nickles, 0 pennies");
        }
    }
}