namespace ThreadHomework.IntCalculating;

internal class ParallelThreadIntCalculating : IIntCalculating
{
    public string TypeOfCalculation => "Thread";

    public int GetSum(int[] ints)
    {
        // Определение кол-ва потоков и разбиение массива по потокам
        int threadsAmount = ints.Length <= 100000 ? 1 : 5;
        int intsCountInThread = ints.Length / threadsAmount;
        int[] threadsSum = new int[intsCountInThread];

        int result = 0;

        // Параллельный расчет суммы в каждом потоке
        Parallel.For(0, threadsAmount, (counter) =>
        {
            int sum = 0;
            for (int i = counter * intsCountInThread; i < (counter + 1) * intsCountInThread; i++)
                sum += ints[i];

            threadsSum[counter] = sum;
        });

        // Сложение всех сумм
        foreach (var threadSum in threadsSum)
        {
            result += threadSum;
        }

        return result;
    }
}
