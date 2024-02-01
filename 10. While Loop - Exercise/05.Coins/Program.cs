
double change = double.Parse(Console.ReadLine());
int coinscount = 0;

while (change > 0)
{
    if (change >= 2)
    {
        change -= 2;
        coinscount++;
    }
    else if (change >= 1)
    {
        change -= 1;
        coinscount++;
    }
    else if (change >= 0.5)
    {
        change -= 0.5;
        coinscount++;
    }
    else if (change >= 0.2)
    {
        change -= 0.2;
        coinscount++;
    }
    else if (change >= 0.1)
    {
        change -= 0.1;
        coinscount++;
    }
    else if (change >= 0.05)
    {
        change -= 0.05;
        coinscount++;
    }
    else if (change >= 0.02)
    {
        change -= 0.02;
        coinscount++;
    }
    else if (change >= 0.01)
    {
        change -= 0.01;
        coinscount++;
    }

    change = Math.Round(change, 2);
}
Console.WriteLine(coinscount);