
string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double apartmentPrice = 0;
double studioPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = nights * 50;
    apartmentPrice = nights * 65;

    if (nights > 7 && nights <= 14)
    {
        studioPrice -= studioPrice * 0.05;
    }
    else if (nights > 14)
    {
        studioPrice -= studioPrice * 0.3;
        apartmentPrice -= apartmentPrice * 0.1;
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = nights * 75.2;
    apartmentPrice = nights * 68.7;

    if (nights > 14)
    {
        studioPrice -= studioPrice * 0.2;
        apartmentPrice -= apartmentPrice * 0.1;
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = nights * 76;
    apartmentPrice = nights * 77;

    if (nights > 14)
    {
        apartmentPrice -= apartmentPrice * 0.1;
    }
}
Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {studioPrice:F2} lv.");