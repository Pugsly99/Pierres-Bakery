namespace PierresBakery
{
  public class BreadBakery
  {

    public int BreadAmount { get; set; }
    public int BreadPrice { get; set; }

    public void Bread(int amount)
    {
      int free = 0;
      if (amount % 2 != 0)
      {
        amount -= 1;
        free = amount / 2;
        amount += 1;
        BreadPrice = amount * 5;
        amount += free;
        BreadAmount = amount;
      }
      else if (amount % 2 == 0)
      {
        free = amount / 2;
        BreadPrice = amount * 5;
        amount += free;
        BreadAmount = amount;
      }
    }
  }

  public class PastryBakery
  {

    public int PastryAmount { get; set; }
    public int PastryPrice { get; set; }

    public void Pastry(int amount)
    {
      int deal = 0;
      int nondeal = 0;
      if (amount >= 3)
      {
        PastryAmount = amount;
        nondeal = amount % 3;
        deal = amount - nondeal;
        deal = deal / 3;
        deal = deal * 5; 
        nondeal = nondeal * 2;
        PastryPrice = deal + nondeal;
        
      }
      else 
      {
        PastryAmount = amount;
        nondeal = amount * 2;
        PastryPrice = nondeal;
      }
    }
  }
} 
