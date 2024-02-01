using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int pageNumbers = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int dayNumbers = int.Parse(Console.ReadLine());

            int timeOverall = pageNumbers / pagesPerHour;
            int hoursNeededPerDay = timeOverall / dayNumbers;

            Console.WriteLine(hoursNeededPerDay);
        }
    }
}