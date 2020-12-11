using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    
    [TestMethod]
    public void Bread_ReturnsAmountPrice_Int()
    {
      int amount = 11;
      Bakery newBakery = new Bakery();
      newBakery.Bread(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(50, price);
    }

    [TestMethod]
    public void Bread_ReturnsBreadAmount_Int()
    {
      int amount = 10;
      Bakery newBakery = new Bakery();
      newBakery.Bread(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(amount, loaves);
    }

    [TestMethod]
    public void Pastry_ReturnsAmountPrice_Int()
    {
      
    }
  }
}