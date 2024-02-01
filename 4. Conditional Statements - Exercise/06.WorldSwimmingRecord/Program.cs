
double recordInSeconds = double.Parse(Console.ReadLine());
double distanceMeters = double.Parse(Console.ReadLine());
double timeForOneMeter = double.Parse(Console.ReadLine());

double secondsNeeded = distanceMeters * timeForOneMeter;
double everyFiftheenMeters = Math.Floor(distanceMeters / 15);
double addedtwelvepointfiveseconds = everyFiftheenMeters * 12.5;
double timeOverall = secondsNeeded + addedtwelvepointfiveseconds;

if (timeOverall < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {timeOverall:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {timeOverall - recordInSeconds:f2} seconds slower.");
}