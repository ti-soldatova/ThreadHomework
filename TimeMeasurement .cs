using System.Diagnostics;
using ThreadHomework.IntCalculating;

namespace ThreadHomework;

internal class TimeMeasurement
{
    public int[] IntsArray { get; }

    public TimeMeasurement(int amount)
    {
        IntsArray = Enumerable.Range(1, amount).ToArray();
    }

    public void Measure(IIntCalculating intCalculating)
    {
        Stopwatch stopwatch = new Stopwatch();
        long timeMs;

        stopwatch.Start();

        int sum = intCalculating.GetSum(IntsArray);

        stopwatch.Stop();

        timeMs = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Type of calculation: {intCalculating.TypeOfCalculation};  Result: {sum};  Time: {timeMs} ms;");
    }
}
