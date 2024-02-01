using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int bagsNumbersDogs = int.Parse(Console.ReadLine());
            int bagsNumbersCats = int.Parse(Console.ReadLine());

            double dogsMoney = bagsNumbersDogs * 2.50;
            double catsMoney = bagsNumbersCats * 4;

            double sum = dogsMoney + catsMoney;

            Console.WriteLine($"{sum} lv.");
        }
    }
}