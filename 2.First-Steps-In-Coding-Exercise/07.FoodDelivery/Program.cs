using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggie = int.Parse(Console.ReadLine());

            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.40;
            double veggiePrice = veggie * 8.15;

            double menuPrice = chickenPrice + fishPrice + veggiePrice;
            double dessertPrice = menuPrice * 0.2;

            double overallPrice = menuPrice + dessertPrice + 2.50;

            Console.WriteLine(overallPrice);
        }
    }
}