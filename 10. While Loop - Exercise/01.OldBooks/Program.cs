
string nameOfBook = Console.ReadLine();
string searchOfBook = Console.ReadLine();
int bookCounter = 0;

while (searchOfBook != nameOfBook)
{
    searchOfBook = Console.ReadLine();
    bookCounter++;

    if (searchOfBook == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!");
        Console.WriteLine($"You checked {bookCounter} books.");
        break;
    }
}
if (searchOfBook == nameOfBook)
{
    Console.WriteLine($"You checked {bookCounter} books and found it.");
}