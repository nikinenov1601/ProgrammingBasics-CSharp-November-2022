
double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double clothingPerExtra = double.Parse(Console.ReadLine());

double decor = budget * 0.1;
double clothingSum = extras * clothingPerExtra;

if (extras > 150)
{
    clothingSum = clothingSum - (clothingSum * 0.1);
}
double sumTotal = decor + clothingSum;

if (sumTotal <= budget)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - sumTotal:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {sumTotal - budget:f2} leva more.");
}