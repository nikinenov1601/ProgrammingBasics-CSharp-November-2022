
int juryMembers = int.Parse(Console.ReadLine());
string presentationName = Console.ReadLine();

double totalAverageGrade = 0;
int presentationCount = 0;

while (presentationName != "Finish")
{
    double totalGrade = 0;

    for (int i = 0; i < juryMembers; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        totalGrade += grade;
    }

    double averageGrade = totalGrade / juryMembers;
    Console.WriteLine($"{presentationName} - {averageGrade:F2}.");

    totalAverageGrade += averageGrade;
    presentationCount++;

    presentationName = Console.ReadLine();
}

double finalAverage = totalAverageGrade / presentationCount;
Console.WriteLine($"Student's final assessment is {finalAverage:F2}.");