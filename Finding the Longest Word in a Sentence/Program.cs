class Program
{
    static string LongestWord(params string[] str)
    {
        string longestWord = str[0];
        foreach(string word in str)
        {
            if(word.Length >  longestWord.Length){
                longestWord = word;
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
