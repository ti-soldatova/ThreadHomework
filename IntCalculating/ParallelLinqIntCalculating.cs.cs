namespace ThreadHomework.IntCalculating;

internal class ParallelLinqIntCalculating : IIntCalculating
{
    public string TypeOfCalculation => "Parallel";

    public int GetSum(int[] ints) => ints.AsParallel().Aggregate((x, y) => x + y);
}
