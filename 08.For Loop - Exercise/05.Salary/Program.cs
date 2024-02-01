
int count = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string name = Console.ReadLine();

    switch (name)
    {
        case "Facebook":
            budget -= 150;
            break;
        case "Instagram":
            budget -= 100;
            break;
        case "Reddit":
            budget -= 50;
            break;
    }
    if (budget <= 0)
    {
        break;
    }
}
if (budget <= 0)
{
    Console.WriteLine("You have lost your salary.");
}
else
{
    Console.WriteLine(budget);
}