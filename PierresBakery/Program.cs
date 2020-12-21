using PierresBakery.Models;
using System;

namespace PierresBakery
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery.");
      Console.WriteLine("We offer Pastrys and Bread!");
      Console.WriteLine("Here are our deals currently:");
      Console.WriteLine("Bread - Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("Pastry's - Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("**Special Today Only** Pastry's - Buy 5 for $7");
      Console.WriteLine("--------------------------------------------------");

      Console.WriteLine("How many Pastry's would you like?");
      int pastryWanted = int.Parse(Console.ReadLine());

      Console.WriteLine("How many loaves of Bread would you like?");
      int breadWanted = int.Parse(Console.ReadLine());

      PastryOrder pastry = new PastryOrder();
      BreadOrder bread = new BreadOrder();

      pastry.PastryCheckout(pastryWanted);

      bread.BreadCheckout(breadWanted);

      Console.WriteLine("Pastry Received: " + pastry.PastryAmount);
      Console.WriteLine("Pastry Price: " + pastry.PastryPrice + "$");

      Console.WriteLine("Bread Received: " +  bread.BreadAmount);
      Console.WriteLine("Bread Price: " + bread.BreadPrice + "$");

      int total = bread.BreadPrice + pastry.PastryPrice;
      Console.WriteLine("Your total today will be: " + total + "$");



    }
  }
}