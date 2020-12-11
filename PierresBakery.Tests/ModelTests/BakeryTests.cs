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
      Bakery newBakery = new Bakery();
      newBakery.Bread(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(55, price);
    }

    public void Bread_EvenReturnsAmountPrice_Int()
    {
      int amount = 10;
      Bakery newBakery = new Bakery();
      newBakery.Bread(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(45, price);
    }

    [TestMethod]
    public void Bread_OddReturnsBreadAmount_Int()
    {
      int amount = 11;
      Bakery newBakery = new Bakery();
      newBakery.Bread(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(16, loaves);
    }

      public void Bread_EvenReturnsBreadAmount_Int()
    {
      int amount = 10;
      Bakery newBakery = new Bakery();
      newBakery.Bread(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(15, loaves);
    }

    [TestMethod]
    public void Pastry_ReturnsAmountPrice_Int()
    {
      
    }
  }
}