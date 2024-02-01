using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int penCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            int litersCleaningLiquid = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double penPrice = penCount * 5.80;
            double markersPrice = markersCount * 7.20;
            double liquidPrice = litersCleaningLiquid * 1.20;
            double priceOverall = penPrice + markersPrice + liquidPrice;
            double priceWithDiscount = priceOverall - (priceOverall * discount / 100);

            Console.WriteLine(priceWithDiscount);
        }
    }
}