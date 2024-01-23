
int examHours = int.Parse(Console.ReadLine());
int examHMinutes = int.Parse(Console.ReadLine());
int arrivalhours = int.Parse(Console.ReadLine());
int arrivalminutes = int.Parse(Console.ReadLine());

int Examtotalminutes = examHours * 60 + examHMinutes;
int arrivalTotalminutes = arrivalhours * 60 + arrivalminutes;

if (arrivalTotalminutes > Examtotalminutes)
{
    Console.WriteLine("Late");
    int minutesdiff = arrivalTotalminutes - Examtotalminutes;

    if (minutesdiff < 60)
    {
        Console.WriteLine($"{minutesdiff} minutes after the start");
    }
    else
    {
        int hours = minutesdiff / 60;
        int minutes = minutesdiff % 60;
        Console.WriteLine($"{hours} : {minutes:d2} hours after the start");
    }
}
else if (arrivalTotalminutes < Examtotalminutes - 30)
{
    Console.WriteLine("Early");
    int minutesdiff = Examtotalminutes - arrivalTotalminutes;

    if (minutesdiff < 60)
    {
        Console.WriteLine($"{minutesdiff} minutes before the start");
    }
    else
    {
        int hours = minutesdiff / 60;
        int minutes = minutesdiff % 60;
        Console.WriteLine($"{hours} : {minutes:d2} hours before the start");
    }
}
else
{
    Console.WriteLine("On time");
    int minutesdiff = Examtotalminutes - arrivalTotalminutes;
    Console.WriteLine($"{minutesdiff} minutes before the start");

}