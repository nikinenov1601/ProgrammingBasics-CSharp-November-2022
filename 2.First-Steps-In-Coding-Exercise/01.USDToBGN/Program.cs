using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double bgn = double.Parse(Console.ReadLine());
            double usd = bgn * 1.79549;

            Console.WriteLine(usd);
        }
    }
}