
int sumPrime = 0, sumNonPrime = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "stop")
        break;

    if (int.TryParse(input, out int number) && number >= 0)
    {
        bool isPrime = true;

        if (number <= 1)
            isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            sumPrime += number;
        else
            sumNonPrime += number;
    }
    else
    {
        Console.WriteLine("Number is negative.");
    }
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");