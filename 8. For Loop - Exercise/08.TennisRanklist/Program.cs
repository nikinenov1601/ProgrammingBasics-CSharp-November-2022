
int tournamentsCount = int.Parse(Console.ReadLine());
double startingPoints = double.Parse(Console.ReadLine());
double addedPoints = 0;
double tournametsWon = 0;

for (int i = 0; i < tournamentsCount; i++)
{
    string result = Console.ReadLine();


    switch (result)
    {
        case "W":
            addedPoints += 2000;
            tournametsWon++;
            break;
        case "F":
            addedPoints += 1200;
            break;
        case "SF":
            addedPoints += 720;
            break;
    }
}
double finalPoints = addedPoints + startingPoints;
double averagePoints = addedPoints / tournamentsCount;
double percentTournamentsWon = tournametsWon / tournamentsCount * 100;

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{percentTournamentsWon:f2}%");