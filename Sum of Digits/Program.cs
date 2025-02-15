namespace ConsoleApp3;
//Task 3: Sum of Digits
// Task: Compute the sum of all digits of a given number using a loop (e.g., 456 → 4 + 5 + 6 = 15).

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter your number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine(sum);
    }
}
