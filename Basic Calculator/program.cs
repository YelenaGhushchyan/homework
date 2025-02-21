class Program
{
    static void Add(int a, int b)
    {
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }

    static void Subtract(int a, int b)
    {
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
    }

    static void Multiply(int a, int b)
    {
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
    }

    static void Divide(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
        else
        {
            Console.WriteLine("b mustn't be zero ");
        }
    }

    static void Calculator()
    {
        Console.WriteLine("Enter operation {+,-,*,/} or X to exit: ");
        string operation = Console.ReadLine();

        if (operation.ToUpper() == "X") return;
        Console.WriteLine("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        switch (operation)
        {
            case "+":
                Add(num1, num2);
                break;
            case "-":
                Subtract(num1, num2);
                break;
            case "*":
                Multiply(num1, num2);
                break;
            case "/":
                Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation! Try again.");
                break;
        }

        Calculator();
    }

    static void Main(string[] args)
    {
        Calculator();
    }
