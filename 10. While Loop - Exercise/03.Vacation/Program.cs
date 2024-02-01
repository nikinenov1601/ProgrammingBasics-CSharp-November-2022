
double moneyNeeded = double.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());
int daysSpendingCounter = 0;
int daysCounter = 0;

while (moneyNeeded > budget && daysSpendingCounter < 5)
{
    string command = Console.ReadLine();
    daysCounter++;

    if (command == "spend")
    {
        double spentMoney = double.Parse(Console.ReadLine());
        budget -= spentMoney;
        daysSpendingCounter++;

        if (budget < 0)
        {
            budget = 0;
        }
    }
    else if (command == "save")
    {
        double savedMoney = double.Parse(Console.ReadLine());
        budget += savedMoney;
        daysSpendingCounter = 0;
    }
}
if (daysSpendingCounter == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysCounter);
}
if (budget >= moneyNeeded)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}