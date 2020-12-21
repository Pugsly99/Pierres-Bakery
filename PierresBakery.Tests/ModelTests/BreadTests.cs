using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    
    [TestMethod]
    public void Bread_OddReturnsAmountPrice_Int()
    {
      int amount = 11;
      BreadOrder newBakery = new BreadOrder();
      newBakery.BreadCheckout(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(55, price);
    }

    [TestMethod]
    public void Bread_EvenReturnsAmountPrice_Int()
    {
      int amount = 10;
      BreadOrder newBakery = new BreadOrder();
      newBakery.BreadCheckout(amount);
      int price = newBakery.BreadPrice;
      Assert.AreEqual(50, price);
    }

    [TestMethod]
    public void Bread_OddReturnsBreadAmount_Int()
    {
      int amount = 11;
      BreadOrder newBakery = new BreadOrder();
      newBakery.BreadCheckout(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(16, loaves);
    }

    [TestMethod]
    public void Bread_EvenReturnsBreadAmount_Int()
    {
      int amount = 10;
      BreadOrder newBakery = new BreadOrder();
      newBakery.BreadCheckout(amount);
      int loaves = newBakery.BreadAmount;
      Assert.AreEqual(15, loaves);
    }

  }
}