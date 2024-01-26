
int gonumber = int.Parse(Console.ReadLine());
int sumofnumber = 0;

while (sumofnumber < gonumber)
{
    int currentnumber = int.Parse(Console.ReadLine());
    sumofnumber += currentnumber;
}

Console.WriteLine(sumofnumber);