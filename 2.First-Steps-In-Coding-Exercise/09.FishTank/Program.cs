using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int longtitude = int.Parse(Console.ReadLine());
            int latitude = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumVolume = longtitude * latitude * height;
            double volumeLiters = aquariumVolume / 1000;
            double spaceTaken = percent * 0.01;

            double litersNeeded = volumeLiters * (1 - spaceTaken);

            Console.WriteLine(litersNeeded);
        }
    }
}