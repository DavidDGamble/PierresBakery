using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\nWelcome to Pierre's Bakery! \nBread: $5 (buy 2, get 1 free!) \nPastries: $2 (buy 2, get the 3rd for $1!) \n\nEnter the number of loaves of bread you would like to purchase:");
      string breadInput = Console.ReadLine();
      int userBread = 0;
      while (!int.TryParse(breadInput, out userBread) || int.Parse(breadInput) < 0)
      {
        Console.WriteLine("INVALID ENTRY! \nEnter the number of loaves of bread you would like to purchase:");
        breadInput = Console.ReadLine();
      }

      Console.WriteLine("\nEnter the number of pastries you would like to purchase:");
      string pastryInput = Console.ReadLine();
      int userPastries = 0;
      while (!int.TryParse(pastryInput, out userPastries) || int.Parse(pastryInput) < 0)
      {
        Console.WriteLine("INVALID ENTRY! \nEnter the number of pasties you would like to purchase:");
        pastryInput = Console.ReadLine();
      }

      Bread bread = new Bread(userBread);
      bread.CalcTotal();
      Pastry pastry = new Pastry(userPastries);
      pastry.CalcTotal();

      Console.WriteLine("\nYour total is: $" + (bread.GetTotalCost() + pastry.GetTotalCost()) + ".00 \n\nWould you like to place another order? \nenter [yes/no]");
      string userInput = Console.ReadLine();
      while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
      {
        Console.WriteLine("\nINVALID ENTRY! \nWould you like to place another order? \nenter [yes/no]");
        userInput = Console.ReadLine();
      }

      if (userInput.ToLower() == "yes")
      {
        Main();
      }
    }
  }
}