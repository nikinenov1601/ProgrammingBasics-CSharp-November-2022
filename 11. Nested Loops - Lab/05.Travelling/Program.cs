string command = Console.ReadLine();

while (command != "End")
{
    double cost = double.Parse(Console.ReadLine());
    double budget = 0;

    while (budget < cost)
    {
        double saving = double.Parse((Console.ReadLine()));
        budget += saving;
    }
    if (budget >= cost)
    {
        Console.WriteLine($"Going to {command}!");
    }

    command = Console.ReadLine();
}
