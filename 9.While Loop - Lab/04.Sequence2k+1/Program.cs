
int number = int.Parse(Console.ReadLine());
int newNumber = 1;

while (newNumber <= number)
{
    Console.WriteLine(newNumber);
    newNumber = newNumber * 2 + 1;
}