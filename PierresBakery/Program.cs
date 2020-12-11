using PierresBakery;
using System;

namespace PierresBakery.Models
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
      Console.WriteLine("--------------------------------------------------");

      Console.WriteLine("How many Pastry's would you like?");
      int pastryResponse = int.Parse(Console.ReadLine());
      int pastryPrice = 0;
      int pastryAmount = 0;

      Console.WriteLine("How many loaves of Bread would you like?");
      int breadResponse = int.Parse(Console.ReadLine());
      int breadPrice = 0;
      int breadAmount = 0;

      Bakery newBakery = new Bakery();

      newBakery.Pastry(pastryResponse);
      pastryPrice = newBakery.PastryPrice;
      pastryAmount = newBakery.PastryAmount;

      newBakery.Bread(breadResponse);
      breadPrice = newBakery.BreadPrice;
      breadAmount = newBakery.BreadAmount;

      Console.WriteLine("Pastry Received: " + pastryAmount);
      Console.WriteLine("Pastry Price: " + pastryPrice + "$");

      Console.WriteLine("Bread Received: " + breadAmount);
      Console.WriteLine("Bread Price: " + breadPrice + "$");

      int total = breadPrice + pastryPrice;
      Console.WriteLine("Your total today will be: " + total + "$");



    }
  }
}