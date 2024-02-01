

double budget = double.Parse(Console.ReadLine());
int GPU = int.Parse(Console.ReadLine());
int CPU = int.Parse(Console.ReadLine());
int RAM = int.Parse(Console.ReadLine());

double gpuPrice = GPU * 250;
double cpuPrice = CPU * (gpuPrice * 0.35);
double ramPrice = RAM * (gpuPrice * 0.1);

double overallPrice = gpuPrice + cpuPrice + ramPrice;

if (GPU > CPU)
{
    overallPrice -= overallPrice * 0.15;
}
if (budget >= overallPrice)
{
    Console.WriteLine($"You have {budget - overallPrice:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {overallPrice - budget:f2} leva more!");
}