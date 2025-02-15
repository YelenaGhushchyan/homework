using System;
//Task 1: Fibonacci Sequence Generator
// Task: Write a program that generates the first N numbers of the Fibonacci sequence using a loop.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter your number");
        int n = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
        if (n > 1)
        {
            Console.Write(second);
        }

        for (int i = 2; i <= n; i++)
        {
            int next = first + second;
            Console.Write(next);
            first = second;
            second = next;
        }
        Console.WriteLine();
    }
}