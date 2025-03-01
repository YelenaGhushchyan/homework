public class InkReservoir
{
    private string Color;
    private double InkAmount;

    public InkReservoir(string color, double inkAmount)
    {
        Color = color;
        InkAmount = inkAmount;
    }

    public static InkReservoir operator +(InkReservoir a, InkReservoir b)
    {
        InkReservoir res = new InkReservoir(a.Color, a.InkAmount);
        if (a.Color == b.Color)
        {
            res.InkAmount = a.InkAmount + b.InkAmount;
        }
        else
        {
            return a;
        }

        return res;
    }
    public static InkReservoir operator -(InkReservoir a, InkReservoir b)
    {
        InkReservoir res = new InkReservoir(a.Color, a.InkAmount);
        res.InkAmount = (a.InkAmount > b.InkAmount) ? (a.InkAmount - b.InkAmount) : (b.InkAmount - a.InkAmount);
        return res;
    }

    public override string ToString()
    {
        return $"color {Color}, InkAmount {InkAmount}";
    }
}

class Program
{
    static void Main()
    {
        InkReservoir a = new InkReservoir("blue", 10);
        InkReservoir b = new InkReservoir("blue", 28);
        InkReservoir c = a + b;
        Console.WriteLine(c);
        InkReservoir e = a - b;
        Console.WriteLine(e);
       
    }
}
