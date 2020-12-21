namespace PierresBakery.Models
{
  public class BreadOrder
  {

    public int BreadAmount { get; set; }
    public int BreadPrice { get; set; }

    public void BreadCheckout(int amount)
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
} 
