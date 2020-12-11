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
      int price = newBakery.BreadPrice;
      Assert.AreEqual(amount, price);
    }

    [TestMethod]
    public void Pastry_ReturnsAmountPrice_Int()
    {
      
    }
  }
}