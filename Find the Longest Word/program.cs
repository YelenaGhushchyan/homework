class Program
{
    static string LongestWord(params string[] str)
    {
        string longestWord = str[0];
        int maxLength = str[0].Length;
        for (int i = 1; i < str.Length; i++)
        {
            if (maxLength < str[i].Length)
            {
                maxLength = str[i].Length;
                longestWord = str[i];
            }
        }
        return longestWord;
    }
    static void Main(string[] args)
    {
        string sentance  = Console.ReadLine();
        string[] array = sentance.Split(' ');
        string longestWord = LongestWord(array);
        Console.WriteLine($"Longest word is {longestWord}");
    }
}
