namespace ConsoleApp9;
// Task 9: Finding the Longest Word in a Sentence
// Task: Ask the user for a sentence and use a loop to determine the longest word.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write sentence ");
        string? sentence = Console.ReadLine();
        string[] arr = sentence.Split(" ");
        int maxCount = 0;
        string maxWord = "";
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > maxCount)
            {
                maxCount = arr[i].Length;
                maxWord = arr[i];
            }
        }
        Console.WriteLine("{0} {1}",maxWord,maxCount);
        
    }
}
