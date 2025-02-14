namespace ConsoleApp7;
//Task 7: Number Pyramid
// Task: Print a number pyramid using nested loops, like:
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter n");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i} ");
            }
                Console.WriteLine();
        }
        
    }
}