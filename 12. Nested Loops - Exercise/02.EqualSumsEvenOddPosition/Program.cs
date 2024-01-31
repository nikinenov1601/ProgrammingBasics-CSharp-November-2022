
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

for (int i = firstNumber; i <= secondNumber; i++)
{
    string numberAsString = i.ToString();
    int evenSum = 0;
    int oddSum = 0;

    for (int j = 0; j < numberAsString.Length; j++)
    {
        int currDigit = int.Parse(numberAsString[j].ToString());

        if (j % 2 == 0)
        {
            evenSum += currDigit;
        }
            
        else
        {
            oddSum += currDigit;
        }
    }

    if (evenSum == oddSum)
        Console.Write(i + " ");
}