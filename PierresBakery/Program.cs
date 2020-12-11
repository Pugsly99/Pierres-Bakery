using System;

namespace PierresBakery.Models
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery.");
      Console.WriteLine("We currently offer Pastrys and Bread!");
      Console.WriteLine("Here are our deals currently:");
      Console.WriteLine("Bread - Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("Pastry - Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("--------------------------------------------------");

      Console.WriteLine("How many Pastry's would you like?");
      int pastryResponse = Console.ReadLine();
      int pastryPrice = 0;
      int pastryAmount = 0;

      Console.WriteLine("How many loaves of Bread would you like?");
      int breadResponse = Console.ReadLine();
      int breadPrice = 0;
      int breadAmount = 0;

    }
  }
}