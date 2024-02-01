
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = "";
string typeOfVacation = "";
double sumSpent = 0;

if (budget <= 100)
{
    destination = "Bulgaria";

    if (season == "summer")
    {
        typeOfVacation = "Camp";
        sumSpent = budget * 0.3;
    }
    else if (season == "winter")
    {
        typeOfVacation = "Hotel";
        sumSpent = budget * 0.7;
    }
}
else if (budget <= 1000 && budget > 100)
{
    destination = "Balkans";

    if (season == "summer")
    {
        typeOfVacation = "Camp";
        sumSpent = budget * 0.4;
    }
    else if (season == "winter")
    {
        typeOfVacation = "Hotel";
        sumSpent = budget * 0.8;
    }
}
else
{
    destination = "Europe";
    typeOfVacation = "Hotel";
    sumSpent = budget * 0.9;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeOfVacation} - {sumSpent:f2}");