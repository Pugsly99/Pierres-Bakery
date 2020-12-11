namespace PierresBakery
{
  public class Bakery
  {

    public int Bread { get; set; }
    public int BreadPrice { get; set; }
    public int Pastry { get; set; }
    public int PastryPrice { get; set; }

    public Bread(int amount)
    {
      int free = 0;
      if (amount / 2 != 0)
      {
        amount -= 1;
        free = amount / 2;
        BreadPrice = amount * 5;
        amount = free + 1;
        Bread = amount;

      }
      else if (amount / 2 == 0)
      {
        free = amount / 2;
        BreadPrice = amount * 5;
        amount = free;
        Bread = amount;
      }
    }

    public Pastry(int amount)
    {
      if (amount % 2 != 0)
      {
        amount -= 1;
        

      }
      else 
      {

      }
    }
  }
}
