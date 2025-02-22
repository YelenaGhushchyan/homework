public class Smartwatch
{
    public string ownerName;
    public int stepCount;
    public Smartwatch(string name){
        ownerName = name;
        stepCount = 0;
    }

    public void AddSteps(int steps)
    {
        stepCount += steps;
    }

   public void ShowSteps()
    {
        
        Console.WriteLine($"{ownerName}'s stepcount is  {stepCount} ");
    }
}
}

class Program
{
    static void Main(string[] args)
    {
        Smartwatch smartwatch = new Smartwatch("Ann");
        smartwatch.AddSteps(5);
        smartwatch.AddSteps(12);
        smartwatch.ShowSteps();
    }
}
