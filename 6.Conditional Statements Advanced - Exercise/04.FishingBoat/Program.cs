
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermans = int.Parse(Console.ReadLine());
double price = 0;

if (season == "Spring")
{
    price = 3000;

    if (fishermans <= 6)
    {
        price -= price * 0.1;
    }
    else if (fishermans >= 7 && fishermans <= 11)
    {
        price -= price * 0.15;
    }
    else if (fishermans >= 12)
    {
        price -= price * 0.25;
    }

    if (fishermans % 2 == 0)
    {
        price -= price * 0.05;
    }
}
else if (season == "Summer")
{
    price = 4200;

    if (fishermans <= 6)
    {
        price -= price * 0.1;
    }
    else if (fishermans >= 7 && fishermans <= 11)
    {
        price -= price * 0.15;
    }
    else if (fishermans >= 12)
    {
        price -= price * 0.25;
    }

    if (fishermans % 2 == 0)
    {
        price -= price * 0.05;
    }
}
else if (season == "Autumn")
{
    price = 4200;

    if (fishermans <= 6)
    {
        price -= price * 0.1;
    }
    else if (fishermans >= 7 && fishermans <= 11)
    {
        price -= price * 0.15;
    }
    else if (fishermans >= 12)
    {
        price -= price * 0.25;
    }
}
else if (season == "Winter")
{
    price = 2600;

    if (fishermans <= 6)
    {
        price -= price * 0.1;
    }
    else if (fishermans >= 7 && fishermans <= 11)
    {
        price -= price * 0.15;
    }
    else if (fishermans >= 12)
    {
        price -= price * 0.25;
    }

    if (fishermans % 2 == 0)
    {
        price -= price * 0.05;
    }
}
if (budget >= price)
{
    Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
}