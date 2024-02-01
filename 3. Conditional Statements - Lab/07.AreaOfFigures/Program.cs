
string figure = Console.ReadLine();

if (figure == "square")
{
    double a = double.Parse(Console.ReadLine());
    double S = a * a;

    Console.WriteLine($"{S:f3}");
}
else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double S = a * b;

    Console.WriteLine($"{S:f3}");
}
else if (figure == "circle")
{
    double a = double.Parse(Console.ReadLine());
    double S = a * a * Math.PI;
    Console.WriteLine($"{S:f3}");
}
else if (figure == "triangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double S = (a * b) / 2;

    Console.WriteLine($"{S:f3}");
}