
int days = int.Parse(Console.ReadLine());
string typeofroom = Console.ReadLine();
string rating = Console.ReadLine();

int nights = days - 1;
double price = 0.0;

if (typeofroom == "room for one person")
{
    price = nights * 18.00;
}
else if (typeofroom == "apartment")
{
    price = nights * 25.00;

    if (days > 15)
    {
        price = price - (price * 0.5);
    }
    else if (days >= 10 && days <= 15)
    {
        price = price - (price * 0.35);
    }
    else
    {
        price = price - (price * 0.3);
    }

}
else
{
    price = nights * 35.00;

    if (days > 15)
    {
        price = price - (price * 0.2);
    }
    else if (days >= 10 && days <= 15)
    {
        price = price - (price * 0.15);
    }
    else
    {
        price = price - (price * 0.1);
    }
}
if (rating == "positive")
{
    price = price + (price * 0.25);
}
else if (rating == "negative")
{
    price = price - (price * 0.1);
}
Console.WriteLine($"{price:f2}");