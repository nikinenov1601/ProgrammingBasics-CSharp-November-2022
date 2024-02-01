using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int yealryPayment = int.Parse(Console.ReadLine());

            double sneakersPrice = yealryPayment - (yealryPayment * 0.4);
            double jerseyPrice = sneakersPrice - (sneakersPrice * 0.2);
            double basketballPrice = jerseyPrice * 0.25;
            double basketballAccessories = basketballPrice * 0.2;

            double equipmentOverall = yealryPayment + sneakersPrice + basketballPrice + basketballAccessories + jerseyPrice;

            Console.WriteLine(equipmentOverall);

        }
    }
}