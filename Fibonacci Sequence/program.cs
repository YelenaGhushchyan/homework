class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n-1) + Fibonacci(n - 2);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find its Fibonacci number: ");
        int n = int.Parse(Console.ReadLine());  
        int result = Fibonacci(n);
        Console.WriteLine("The {0}-th Fibonacci number is: {1}", n, result);
    }
}
