using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint + paint * 0.1) * 14.50;
            double diluentPrice = diluent * 5.00;
            double priceOverall = nylonPrice + paintPrice + diluentPrice + 0.40;
            double workersPrice = (priceOverall * 0.3) * hours;
            double finalPrice = priceOverall + workersPrice;


            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}