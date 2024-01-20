

double excursionPrice = double.Parse(Console.ReadLine());
int puzzleCount = int.Parse(Console.ReadLine());
int talkingDolls = int.Parse(Console.ReadLine());
int teddyBears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double sum = (puzzleCount * 2.6) + (talkingDolls * 3.0) + (teddyBears * 4.1) + (minions * 8.2) + (trucks * 2.0);
int count = puzzleCount + talkingDolls + teddyBears + minions + trucks;

if (count >= 50)
{
    sum = sum * 0.75;
}
sum = sum * 0.9;

if (sum >= excursionPrice)
{
    Console.WriteLine($"Yes! {sum - excursionPrice:f2} lv left.");
}

else
{
    Console.WriteLine($"Not enough money! {excursionPrice - sum:f2} lv needed.");
}
