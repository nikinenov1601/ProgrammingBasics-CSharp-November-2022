using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int deadline = int.Parse(Console.ReadLine());
            double percentInterest = double.Parse(Console.ReadLine());

            double interestSum = depositSum * percentInterest / 100;
            double interestPerMonth = interestSum / 12;
            double finalSum = depositSum + deadline * interestPerMonth;

            Console.WriteLine(finalSum);
        }
    }
}