using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int numberOfSandwiches;
int numberOfToppings;
double tip;

double totalSandwichCost;
double totalToppingCost;
double baseCost;

const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

//Prompt user for the number of sandwiches
//Input numberOfSandwiches
Console.WriteLine("Please give the number of sandwiches in the order");
numberOfSandwiches = Convert.ToInt32(Console.ReadLine());
//Prompt user for the number of toppings needed
Console.WriteLine("Please give the number of toppings in the order");
numberOfToppings = Convert.ToInt32(Console.ReadLine());
//Input numberOfToppings

    //Prompt user for the tip
    Console.WriteLine("Please give the tip amount for the order");
    //Input tip
    tip = Convert.ToDouble(Console.ReadLine());
    totalSandwichCost = COST_OF_SANDWICH *  numberOfSandwiches;
    totalToppingCost = COST_OF_TOPPING * numberOfToppings;
    baseCost = totalSandwichCost + totalToppingCost;

    double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

    //Display orderCost
    Console.WriteLine("Total cost is " + Math.Round(orderCost,2));
    }
  }
}
