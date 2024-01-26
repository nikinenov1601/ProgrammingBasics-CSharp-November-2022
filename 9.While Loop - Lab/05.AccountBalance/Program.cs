
string input = Console.ReadLine();

double totalsum = 0;

while (input != "NoMoreMoney")
{
    double inputasnumber = double.Parse(input);
    if (inputasnumber < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {inputasnumber:f2}");
    totalsum += inputasnumber;
    input = Console.ReadLine();
}
Console.WriteLine($"Total: {totalsum:f2}");