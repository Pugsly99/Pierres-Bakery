using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    
    [TestMethod]
    public void Pastry_EvenReturnsAmountPrice_Int()
    {
      int amount = 10;
      PastryOrder newBakery = new PastryOrder();
      newBakery.PastryCheckout(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(14, pastry);
    }

    [TestMethod]
    public void Pastry_OddReturnsAmountPrice_Int()
    {
      int amount = 11;
      PastryOrder newBakery = new PastryOrder();
      newBakery.PastryCheckout(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(16, pastry);
    }

    [TestMethod]
    public void Pastry_LessThan3ReturnsAmountPrice_Int()
    {
      int amount = 2;
      PastryOrder newBakery = new PastryOrder();
      newBakery.PastryCheckout(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(4, pastry);
    }

      [TestMethod]
    public void Pastry_MoreThan5ReturnsAmountPrice_Int()
    {
      int amount = 5;
      PastryOrder newBakery = new PastryOrder();
      newBakery.PastryCheckout(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(7, pastry);
    }

    [TestMethod]
    public void Pastry_ReturnsPastryAmount_Int()
    {
      int amount = 2;
      PastryOrder newBakery = new PastryOrder();
      newBakery.PastryCheckout(amount);
      int pastry = newBakery.PastryAmount;
      Assert.AreEqual(2, pastry);
    }
  }
}