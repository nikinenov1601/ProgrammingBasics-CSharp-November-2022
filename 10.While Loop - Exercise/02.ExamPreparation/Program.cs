
int failedthreshold = int.Parse(Console.ReadLine());
int failedtimes = 0;
int solvedproblemscount = 0;
double gradesum = 0;
string lastproblem = "";
bool isfailed = true;

while (failedtimes < failedthreshold)
{
    string problemname = Console.ReadLine();
    if (problemname == "Enough")
    {
        isfailed = false;
        break;
    }
    int grade = int.Parse(Console.ReadLine());
    if (grade <= 4)
    {
        failedtimes++;
    }
    gradesum += grade;
    solvedproblemscount++;
    lastproblem = problemname;
}
if (isfailed)
{
    Console.WriteLine($"You need a break, {failedthreshold} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {gradesum / solvedproblemscount:f2}");
    Console.WriteLine($"Number of problems: {solvedproblemscount}");
    Console.WriteLine($"Last problem: {lastproblem}");
}