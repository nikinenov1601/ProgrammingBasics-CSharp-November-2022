
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operatorr = Console.ReadLine();
string oddorNot = "";

double result = 0;

if (operatorr == "+")
{
    result = firstNumber + secondNumber;
    if (result % 2 == 0)
    {
        oddorNot = "even";
    }
    else
    {
        oddorNot = "odd";

    }
    Console.WriteLine($"{firstNumber} {operatorr} {secondNumber} = {result} - {oddorNot}");
}
else if (operatorr == "-")
{
    result = firstNumber - secondNumber;
    if (result % 2 == 0)
    {
        oddorNot = "even";
    }
    else
    {
        oddorNot = "odd";

    }
    Console.WriteLine($"{firstNumber} {operatorr} {secondNumber} = {result} - {oddorNot}");
}
else if (operatorr == "*")
{
    result = firstNumber * secondNumber;
    if (result % 2 == 0)
    {
        oddorNot = "even";
    }
    else
    {
        oddorNot = "odd";

    }
    Console.WriteLine($"{firstNumber} {operatorr} {secondNumber} = {result} - {oddorNot}");
}
else if (operatorr == "/")
{
    if (firstNumber == 0)
    {
        Console.WriteLine($"Cannot divide {secondNumber} by zero");
    }
    else if (secondNumber == 0)
    {
        Console.WriteLine($"Cannot divide {firstNumber} by zero");
    }
    else
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber} {operatorr} {secondNumber} = {result:f2}");
    }
}
else if (operatorr == "%")
{
    if (firstNumber == 0)
    {
        Console.WriteLine($"Cannot divide {secondNumber} by zero");
    }
    else if (secondNumber == 0)
    {
        Console.WriteLine($"Cannot divide {firstNumber} by zero");
    }
    else
    {
        result = firstNumber % secondNumber;
        Console.WriteLine($"{firstNumber} {operatorr} {secondNumber} = {result}");
    }
}