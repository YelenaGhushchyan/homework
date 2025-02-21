 static void SolveQuadraticEquation(ref double a, ref double b, ref double c, out double root1, out double root2)
    {
       root1 = root2 = 0;
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Root1: {0}, Root2: {1}", root1, root2);
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            root2 = root1; 
            Console.WriteLine("Root1: {0}", root1);
        }
        else
        {
            Console.WriteLine("Error");
        } 
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double root1, root2;
        SolveQuadraticEquation(ref a, ref b, ref c, out root1, out root2);
    }
}
