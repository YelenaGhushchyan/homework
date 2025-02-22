public class Product
{
    public string name;
    public int price;
    public int quantity;

    public Product(string name, int price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public void Print()
    {
        Console.WriteLine("Product name: " + this.name);
        Console.WriteLine("Product price: " + this.price);
        Console.WriteLine("Product quantity: " + this.quantity);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("A", 100, 10);
        p1.Print();
    }

}
