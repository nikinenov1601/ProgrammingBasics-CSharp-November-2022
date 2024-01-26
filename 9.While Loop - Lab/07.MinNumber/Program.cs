
string input = Console.ReadLine();
double maxNumber = double.Parse(Console.ReadLine());

while (input != "Stop")
{
    double inputAsNumber = double.Parse(input);

    if (inputAsNumber < maxNumber)
    {
        maxNumber = inputAsNumber;
    }
    input = Console.ReadLine();
}
Console.WriteLine(maxNumber);