﻿int count = int.Parse(Console.ReadLine());
int oddSum = 0;
int evenSum = 0;

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}

if (evenSum == oddSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {oddSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
}