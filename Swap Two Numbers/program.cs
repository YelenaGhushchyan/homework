class Program
{
    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        swap(ref num1, ref num2);
        Console.WriteLine("{0},{1}",num1,num2);
    }
}
