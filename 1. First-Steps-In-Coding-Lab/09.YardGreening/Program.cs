using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMetersGreened = double.Parse(Console.ReadLine());
            double greeningPrice = sqMetersGreened * 7.61;
            double discout = greeningPrice * 0.18;
            double finalPrice = greeningPrice - discout;

            Console.WriteLine($"The final price is {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is {discout:f2} lv.");
        }
    }
}