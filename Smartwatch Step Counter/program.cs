public class Smartwatch
{
    public string ownerName;
    public int stepCount;

    public void AddSteps(int steps)
    {
        stepCount += steps;
    }

    public void ShowSteps()
    {
        Console.WriteLine("Steps: " + stepCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Smartwatch smartwatch = new Smartwatch();
        smartwatch.AddSteps(5);
        smartwatch.AddSteps(12);
        smartwatch.ShowSteps();
    }
}
