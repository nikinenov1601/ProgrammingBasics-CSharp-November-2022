
int totalTickets = 0;
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

while (true)
{
    string movieName = Console.ReadLine();
    if (movieName == "Finish")
        break;

    int totalSeats = int.Parse(Console.ReadLine());
    int currentSeats = totalSeats;

    while (currentSeats > 0)
    {
        string ticketType = Console.ReadLine();

        if (ticketType == "End")
            break;

        currentSeats--;
        totalTickets++;

        switch (ticketType)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            case "kid":
                kidTickets++;
                break;
        }
    }

    double percentFull = ((totalSeats - currentSeats) / (double)totalSeats) * 100;
    Console.WriteLine($"{movieName} - {percentFull:F2}% full.");
}

double percentStudent = (studentTickets / (double)totalTickets) * 100;
double percentStandard = (standardTickets / (double)totalTickets) * 100;
double percentKid = (kidTickets / (double)totalTickets) * 100;

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{percentStudent:F2}% student tickets.");
Console.WriteLine($"{percentStandard:F2}% standard tickets.");
Console.WriteLine($"{percentKid:F2}% kids tickets.");
