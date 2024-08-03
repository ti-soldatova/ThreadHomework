namespace ThreadHomework.IntCalculating;

internal interface IIntCalculating
{
    public string TypeOfCalculation { get; }

    public int GetSum(int[] ints);
}
