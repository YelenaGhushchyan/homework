class Program
{
    static int SumOfArr(params int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5};
        int sum = SumOfArr(arr);
        Console.WriteLine(sum);
    }
}
