
using System;

public class TimePeriod
{
    public int TotalSeconds { get; set; }

    public string FormattedTime
    {
        get
        {
            int hours = TotalSeconds / 3600;
            int minutes = (TotalSeconds % 3600) / 60;
            int seconds = TotalSeconds % 60;

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }

    public TimePeriod(int totalSeconds)
    {
        TotalSeconds = totalSeconds;
    }
}

class Program
{
    public static void Main()
    {
        TimePeriod time1 = new TimePeriod(3661);
        Console.WriteLine(time1.FormattedTime);

        TimePeriod time2 = new TimePeriod(590);
        Console.WriteLine(time2.FormattedTime);

        TimePeriod time3 = new TimePeriod(3600);
        Console.WriteLine(time3.FormattedTime);
    }
}
