using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    
    [TestMethod]
    public void Bread_OddReturnsAmountPrice_Int()
    {
      int amount = 11;
      BreadOrder newBakery = new BreadOrder();
      newBakery.Bread(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(55, price);
    }

    [TestMethod]
    public void Bread_EvenReturnsAmountPrice_Int()
    {
      int amount = 10;
      BreadOrder newBakery = new BreadOrder();
      newBakery.Bread(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(50, price);
    }

    [TestMethod]
    public void Bread_OddReturnsBreadAmount_Int()
    {
      int amount = 11;
      BreadOrder newBakery = new BreadOrder();
      newBakery.Bread(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(16, loaves);
    }

    [TestMethod]
    public void Bread_EvenReturnsBreadAmount_Int()
    {
      int amount = 10;
      BreadOrder newBakery = new BreadOrder();
      newBakery.Bread(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(15, loaves);
    }

    [TestMethod]
    public void Pastry_EvenReturnsAmountPrice_Int()
    {
      int amount = 10;
      PastryOrder newBakery = new PastryOrder();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(14, pastry);
    }

    [TestMethod]
    public void Pastry_OddReturnsAmountPrice_Int()
    {
      int amount = 11;
      PastryOrder newBakery = new PastryOrder();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(16, pastry);
    }

    [TestMethod]
    public void Pastry_LessThan3ReturnsAmountPrice_Int()
    {
      int amount = 2;
      PastryOrder newBakery = new PastryOrder();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(4, pastry);
    }

      [TestMethod]
    public void Pastry_MoreThan5ReturnsAmountPrice_Int()
    {
      int amount = 5;
      PastryOrder newBakery = new PastryOrder();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(7, pastry);
    }

    [TestMethod]
    public void Pastry_ReturnsPastryAmount_Int()
    {
      int amount = 2;
      PastryOrder newBakery = new PastryOrder();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryAmount;
      Assert.AreEqual(2, pastry);
    }
  }
}