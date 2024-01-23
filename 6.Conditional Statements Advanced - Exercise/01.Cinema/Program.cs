
string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

double income = 0;

if (type == "Premiere")
{
    income = 12 * rows * columns;
}
else if (type == "Normal")
{
    income = 7.50 * rows * columns;
}

else if (type == "Discount")
{
    income = 5.00 * rows * columns;
}

Console.WriteLine($"{income:f2} leva");