
int count = int.Parse(Console.ReadLine());
double countMusala = 0;
double countMonblan = 0;
double countKillinmandjaro = 0;
double countK2 = 0;
double countEverest = 0;
int sumPeople = 0;

for (int i = 0; i < count; i++)
{
    int numberOfPeople = int.Parse(Console.ReadLine());
    sumPeople += numberOfPeople;

    if (numberOfPeople <= 5)
    {
        countMusala += numberOfPeople;
    }
    else if (numberOfPeople >= 6 && numberOfPeople <= 12)
    {
        countMonblan += numberOfPeople;
    }
    else if (numberOfPeople >= 13 && numberOfPeople <= 25)
    {
        countKillinmandjaro += numberOfPeople;
    }
    else if (numberOfPeople >= 26 && numberOfPeople <= 40)
    {
        countK2 += numberOfPeople;
    }
    else if (numberOfPeople >= 41)
    {
        countEverest += numberOfPeople;
    }
}
double musalaPercent = (countMusala / sumPeople) * 100;
double monblanPercent = (countMonblan / sumPeople) * 100;
double killimandjaroPercent = (countKillinmandjaro / sumPeople) * 100;
double k2Percent = (countK2 / sumPeople) * 100;
double everestPercent = (countEverest / sumPeople) * 100;

Console.WriteLine($"{musalaPercent:f2}%");
Console.WriteLine($"{monblanPercent:f2}%");
Console.WriteLine($"{killimandjaroPercent:f2}%");
Console.WriteLine($"{k2Percent:f2}%");
Console.WriteLine($"{everestPercent:f2}%");