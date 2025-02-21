class Program
{
    static void Temperature(ref double celsius, out double Fahrenheit, out double Kelvin)
    {
        Fahrenheit = celsius * 9 / 5 + 32;
        Kelvin = Fahrenheit - 32;
        Console.WriteLine("{0} {1} {2}", celsius, Fahrenheit, Kelvin);
    }

    static void Main(string[] args)
    {
        double celsius = double.Parse(Console.ReadLine());
        double Kelvin, Fahrenheit;
        Temperature(ref celsius, out Fahrenheit, out Kelvin);
    }
}
