int intervalStart = int.Parse(Console.ReadLine());
int intervalEnd = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int combinationCount = 0;
int validCombination = 0;

for (int a = intervalStart; a <= intervalEnd; a++)
{

    for (int b = intervalStart; b <= intervalEnd; b++)
    {
        combinationCount++;

        if (a + b == magicNumber)
        {
            validCombination++;
            Console.WriteLine($"Combination N:{combinationCount} ({a} + {b} = {magicNumber})");
            break;
        }
    }
    if (validCombination == 1)
    {
        break;
    }
}
if (validCombination != 1)
{
    Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
}
