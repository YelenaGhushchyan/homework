class Program
{
    static void ConvertTime(ref int totalSeconds, out int hours, out int minutes, out int seconds)
    {
        hours = totalSeconds / 3600; 
        totalSeconds %= 3600;        

        minutes = totalSeconds / 60;  
        seconds = totalSeconds % 60; 
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the total number of seconds: ");
        int totalSeconds = int.Parse(Console.ReadLine());  
        int hours, minutes, seconds;
        ConvertTime(ref totalSeconds, out hours, out minutes, out seconds);
        Console.WriteLine("Converted Time: {0} hours, {1} minutes, {2} seconds", hours, minutes, seconds);
}
}  
  
