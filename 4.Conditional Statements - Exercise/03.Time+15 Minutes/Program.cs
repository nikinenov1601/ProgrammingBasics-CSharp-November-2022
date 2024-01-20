
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int result = ((hours * 60) + minutes + 15);
int resultHour = result / 60;
if (resultHour >= 24)
{
    resultHour -= 24;
}
int resultMinutes = result % 60;

Console.WriteLine("{0}:{1:00}", resultHour, resultMinutes);
