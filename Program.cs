
//Processing items:
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;
//Prompt user for the number of sandwiches

Console.WriteLine("input number of sandwiches to purchase");

//Input numberOfSandwiches

int numberOfSandwiches = int.Parse(Console.ReadLine());

//Prompt user for the number of toppings needed

Console.WriteLine("input number of toppings to purchase");

//Input numberOfToppings

int numberOfToppings = int.Parse(Console.ReadLine());

//Prompt user for the tip

Console.WriteLine("input tip amount");

//Input tip

double tip = double.Parse(Console.ReadLine());

double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;
double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);
Console.WriteLine(orderCost);
