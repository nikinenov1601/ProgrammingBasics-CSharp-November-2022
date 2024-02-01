
int age = int.Parse(Console.ReadLine());
double pricewashing = double.Parse(Console.ReadLine());
int toyprice = int.Parse(Console.ReadLine());
double sum = 0;
int moneytobereceived = 10;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        sum += moneytobereceived - 1;
        moneytobereceived += 10;
    }
    else
    {
        sum += toyprice;
    }
}
if (sum < pricewashing)
{
    Console.WriteLine($"No! {pricewashing - sum:f2}");
}
else
{
    Console.WriteLine($"Yes! {sum - pricewashing:f2}");
}