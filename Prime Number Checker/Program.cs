namespace ConsoleApp5;
//Task 5: Prime Number Checker
// Task: Check whether a given number is prime using a loop.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter number ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 1)
        {
            Console.WriteLine("enter greater");
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine($"{number} is not prime");
            }
            else
            {
                {
                    Console.WriteLine($"{number} is prime");
                }
            }
        }
    }
}
