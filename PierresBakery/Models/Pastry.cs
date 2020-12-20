namespace PierresBakery.Models
{
  public class PastryOrder
  {

    public int PastryAmount { get; set; }
    public int PastryPrice { get; set; }

    public void Pastry(int amount)
    {
      int deal = 0;
      int nondeal = 0;
      if (amount >= 5)
      {
        PastryAmount = amount;
        nondeal = amount % 5;
        deal = amount - nondeal;
        deal = deal / 5;
        deal = deal * 7; 
        nondeal = nondeal * 2;
        PastryPrice = deal + nondeal;
      }
      else if (amount >= 3)
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