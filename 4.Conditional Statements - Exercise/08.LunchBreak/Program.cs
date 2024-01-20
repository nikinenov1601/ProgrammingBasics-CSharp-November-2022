
string nameOfSeries = Console.ReadLine();
double episodeLenght = double.Parse(Console.ReadLine());
double restLenght = double.Parse(Console.ReadLine());

double lunchTime = restLenght / 8;
double breakTime = restLenght / 4;

double timeLeft = restLenght - lunchTime - breakTime;

if (timeLeft >= episodeLenght)
{
    Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {Math.Ceiling(timeLeft - episodeLenght)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {Math.Ceiling(episodeLenght - timeLeft)} more minutes.");
}