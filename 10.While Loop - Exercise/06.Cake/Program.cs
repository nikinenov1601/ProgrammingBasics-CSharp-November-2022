
int latitude = int.Parse(Console.ReadLine());
int longtitude = int.Parse(Console.ReadLine());
int piecescount = latitude * longtitude; 

while (true)
{
    string input = Console.ReadLine();

    if (input == "STOP" || piecescount == 0)
    {
        Console.WriteLine($"{piecescount} pieces are left.");
        break;
    }

    int piecestotake = int.Parse(input);
    if (piecestotake > piecescount)
    {
        Console.WriteLine($"No more cake left! You need {piecestotake - piecescount} pieces more.");
        break;
    }
    piecescount -= piecestotake;
}