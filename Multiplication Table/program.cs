namespace ConsoleApp4;
//Task 4: Multiplication Table
// Task: Ask the user for a number N and print its multiplication table up to 10 using a loop.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}"); 
        }
    }
}
