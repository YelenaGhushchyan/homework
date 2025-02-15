namespace ConsoleApp2;
//Task 2: Reverse a Number
// Task: Given an integer, reverse its digits using a loop (e.g., 12345 → 54321).

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter your number ");
        int number = int.Parse(Console.ReadLine());
        int reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        Console.WriteLine(reversed);
    }
}