namespace ConsoleApp6;
//Task 6: Collatz Conjecture
// Task: Given a number N, apply the following rule until N becomes 1:
// If N is even → N = N / 2
// If N is odd → N = 3 * N + 1
// Count how many steps it takes to reach 1.

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }

            count++;
        }
        Console.WriteLine(count);
    }
}
