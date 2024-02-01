
string flower = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());
double overall = 0;

if (flower == "Roses")
{
    overall = count * 5;

    if (count > 80)
    {
        overall -= overall * 0.1;
    }
}
else if (flower == "Dahlias")
{
    overall = count * 3.80;

    if (count > 90)
    {
        overall -= overall * 0.15;
    }
}
else if (flower == "Tulips")
{
    overall = count * 2.80;

    if (count > 80)
    {
        overall -= overall * 0.15;
    }
}
else if (flower == "Narcissus")
{
    overall = count * 3;

    if (count < 120)
    {
        overall += overall * 0.15;
    }
}
else if (flower == "Gladiolus")
{
    overall = count * 2.50;

    if (count < 80)
    {
        overall += overall * 0.2;
    }
}
if (budget >= overall)
{
    Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {budget - overall:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {overall - budget:f2} leva more.");
}