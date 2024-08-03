namespace ThreadHomework.IntCalculating;

internal class SimpleIntCalculating : IIntCalculating
{
    public string TypeOfCalculation => "Simple";

    public int GetSum(int[] ints)
    {
        int result = 0;

        foreach (int i in ints)
        {
            result += i;
        }

        return result;
    }
}
