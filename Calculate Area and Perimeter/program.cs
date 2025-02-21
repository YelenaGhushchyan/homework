class Program
{
    static void Calculate(ref double radius, out double area, out double perimeter)
    {
        area = Math.PI * radius * radius;
        perimeter = Math.PI * 2 * radius;
        Console.WriteLine("the area is " + area);
        Console.WriteLine("the perimeter is " + perimeter);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area, perimeter;
        Calculate(ref radius, out area, out perimeter);
    }
}
