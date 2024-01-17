using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int projectNumbers = int.Parse(Console.ReadLine());
            int hours = projectNumbers * 3;

            Console.WriteLine($"The architect {nameOfArchitect} will need {hours} hours to complete {projectNumbers} project/s.");
        }
    }
}