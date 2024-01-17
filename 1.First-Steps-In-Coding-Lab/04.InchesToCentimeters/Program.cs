using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeters = double.Parse(Console.ReadLine());
            double inches = 2.54;

            double result = centimeters * inches;

            Console.WriteLine(result);
        }
    }
}