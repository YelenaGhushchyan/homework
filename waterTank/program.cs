public class WaterTank
{
    private double Capacity;
    private double CurrentLevel;

    public WaterTank(double capacity, double currentLevel)
    {
        Capacity = capacity;
        CurrentLevel = currentLevel;
    }

    public static WaterTank operator +(WaterTank a, WaterTank b)
    {
        WaterTank res = new WaterTank(a.Capacity, a.CurrentLevel);
        res.Capacity = a.Capacity > b.Capacity ? a.Capacity : b.Capacity;
        res.CurrentLevel = a.CurrentLevel + b.CurrentLevel;
        if (res.CurrentLevel > res.Capacity)
        {
            res.Capacity *= 10;
        }

        return res;
    }

    public override string ToString()
    {
        return $"WaterTank: Capacity = {Capacity}, CurrentLevel = {CurrentLevel}";
    }

    public static WaterTank operator -(WaterTank a, WaterTank b)
    {
        WaterTank res = new WaterTank(a.Capacity, a.CurrentLevel);
        res.Capacity = a.Capacity > b.Capacity ? a.Capacity : b.Capacity;
        res.CurrentLevel = a.CurrentLevel - b.CurrentLevel;
        if (res.CurrentLevel < 0)
        {
            Console.WriteLine("Increase a.CurrentLevel");
            Environment.Exit(1);
        }

        return res;
    }
}



class Program
    {
        static void Main()
        {
            WaterTank a = new WaterTank(10, 10);
            WaterTank b = new WaterTank(20, 8);
            WaterTank c = a - b;
            Console.WriteLine(c);
        }
    }
