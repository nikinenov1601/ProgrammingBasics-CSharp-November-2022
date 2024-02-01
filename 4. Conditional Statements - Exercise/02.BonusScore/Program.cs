
int number = int.Parse(Console.ReadLine());
double extrapoints = 0;

if (number <= 100)
{
    extrapoints = 5;

    if (number % 2 == 0)
    {
        extrapoints += 1;
    }
    else if (number % 10 == 5)
    {
        extrapoints += 2;
    }
}
else if (number > 100 && number <= 1000)
{
    extrapoints = number * 0.2;

    if (number % 2 == 0)
    {
        extrapoints += 1;
    }
    else if (number % 10 == 5)
    {
        extrapoints += 2;
    }
}
else if (number > 1000)
{
    extrapoints = number * 0.1;

    if (number % 2 == 0)
    {
        extrapoints += 1;
    }
    else if (number % 10 == 5)
    {
        extrapoints += 2;
    }
}
double sum = number + extrapoints;

Console.WriteLine(extrapoints);
Console.WriteLine(sum);
