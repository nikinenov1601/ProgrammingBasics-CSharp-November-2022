
int n = int.Parse(Console.ReadLine());

for (int num = 1111; num <= 9999; num++)
{
    bool isSpecial = true;

    string numAsString = num.ToString();
    for (int i = 0; i < numAsString.Length; i++)
    {
        int digit = int.Parse(numAsString[i].ToString());

        if (digit == 0 || n % digit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    if (isSpecial)
    {
        Console.Write(num + " ");
    }
}