// See https://aka.ms/new-console-template for more information
using ThreadHomework;
using ThreadHomework.IntCalculating;

Console.WriteLine("Start working calculating sum of array");

List<int> arrayAmounts = new() { 100000, 1000000, 10000000 };

var simpleCalculating = new SimpleIntCalculating();
var parallelThreadCalculating = new ParallelThreadIntCalculating();
var parallelLinqCalculating = new ParallelLinqIntCalculating();

foreach (int arrayAmount in arrayAmounts)
{
    Console.WriteLine($"Array length: {arrayAmount}");

    TimeMeasurement timeMeasurement = new TimeMeasurement(arrayAmount);

    timeMeasurement.Measure(simpleCalculating);
    timeMeasurement.Measure(parallelThreadCalculating);
    timeMeasurement.Measure(parallelLinqCalculating);
}

Console.WriteLine("End working calculating sum of array");