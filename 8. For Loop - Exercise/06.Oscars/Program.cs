
string nameOfActor = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int juryCount = int.Parse(Console.ReadLine());

for (int i = 0; i < juryCount; i++)
{
    string nameOfJury = Console.ReadLine();
    double pointsGiven = double.Parse(Console.ReadLine());

    double formulaPoints = (nameOfJury.Length * pointsGiven) / 2;
    academyPoints += formulaPoints;

    if (academyPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {academyPoints:f1}!");
        break;
    }
}

if (academyPoints < 1250.5)
{
    Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - academyPoints:f1} more!");
}