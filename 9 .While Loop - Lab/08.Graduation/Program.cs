
string nameOfStudent = Console.ReadLine();

double sumOfGrades = 0;
double exclusionCounters = 0;
double grade = 1;

while (grade <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());

    if (currentGrade < 4)
    {
        exclusionCounters++;
    }
    if (exclusionCounters == 2)
    {
        Console.WriteLine($"{nameOfStudent} has been excluded at {grade - 1} grade");
        break;
    }
    sumOfGrades += currentGrade;
    grade++;
}
if (exclusionCounters != 2)
{
    double averageScore = sumOfGrades / 12;
    Console.WriteLine($"{nameOfStudent} graduated. Average grade: {averageScore:f2}");
}