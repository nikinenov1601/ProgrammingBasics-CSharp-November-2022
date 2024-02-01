
int number = int.Parse(Console.ReadLine());
int sum = 0;
int max = int.MinValue;

for (int i = 0; i < number; i++)
{
    int secondNumber = int.Parse(Console.ReadLine());
    sum += secondNumber;

    if (secondNumber > max)

    {
        max = secondNumber;
    }
}
int sumWithoutMaxNumber = sum - max;
if (max == sumWithoutMaxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    int diff = Math.Abs(max - sumWithoutMaxNumber);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}