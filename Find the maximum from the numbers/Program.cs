class Program
{
    static void FindMax(ref int max, params int[] numbers)
    {
        max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            
        }
        Console.WriteLine("{0}",max);
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        int max = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        FindMax(ref max, numbers);
    }
        
}
