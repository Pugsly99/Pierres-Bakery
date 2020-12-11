using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    
    [TestMethod]
    public void Bread_OddReturnsAmountPrice_Int()
    {
      int amount = 11;
      BreadBakery newBakery = new BreadBakery();
      newBakery.Bread(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(55, price);
    }

    [TestMethod]
    public void Bread_EvenReturnsAmountPrice_Int()
    {
      int amount = 10;
      BreadBakery newBakery = new BreadBakery();
      newBakery.Bread(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(50, price);
    }

    [TestMethod]
    public void Bread_OddReturnsBreadAmount_Int()
    {
      int amount = 11;
      BreadBakery newBakery = new BreadBakery();
      newBakery.Bread(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(16, loaves);
    }

    [TestMethod]
    public void Bread_EvenReturnsBreadAmount_Int()
    {
      int amount = 10;
      BreadBakery newBakery = new BreadBakery();
      newBakery.Bread(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(15, loaves);
    }

    [TestMethod]
    public void Pastry_EvenReturnsAmountPrice_Int()
    {
      int amount = 10;
      PastryBakery newBakery = new PastryBakery();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(14, pastry);
    }

    [TestMethod]
    public void Pastry_OddReturnsAmountPrice_Int()
    {
      int amount = 11;
      PastryBakery newBakery = new PastryBakery();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(16, pastry);
    }

    [TestMethod]
    public void Pastry_LessThan3ReturnsAmountPrice_Int()
    {
      int amount = 2;
      PastryBakery newBakery = new PastryBakery();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(4, pastry);
    }

      [TestMethod]
    public void Pastry_MoreThan5ReturnsAmountPrice_Int()
    {
      int amount = 5;
      PastryBakery newBakery = new PastryBakery();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryPrice;
      Assert.AreEqual(7, pastry);
    }

    [TestMethod]
    public void Pastry_ReturnsPastryAmount_Int()
    {
      int amount = 2;
      PastryBakery newBakery = new PastryBakery();
      newBakery.Pastry(amount);
      int pastry = newBakery.PastryAmount;
      Assert.AreEqual(2, pastry);
    }
  }
}