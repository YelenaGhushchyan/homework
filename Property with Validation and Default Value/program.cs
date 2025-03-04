using System;
public class Product
{
    private float _price;
    private int _stock;
    
    public float Price
    {
        get
        {
            return _price;
        }
        set
        {
            if(value < 0)
            {
                _price = 0;
            }
            else
            {
                _price = value;
            }
        }
    }
    public int Stock
    {
        get
        {
            return _stock;
        }
        set
        {
            if(value < 0)
            {
                _stock = 10;
            }
            else
            {
                _stock = value;
            }
        }
    }
    public Product(float price,int stock)
    {
        _price = price;
        _stock = stock;
    }
    public override string ToString()
    {
        return $"{_price} {_stock}";
    }
}
class Program
{
    public static void Main()
    {
         Product product1 = new Product(15.9f, 5);
         Console.WriteLine(product1);
         Product product2 = new Product(15.4f, 8);
        Console.WriteLine(product2);
        Product product3 = new Product(17.3f, 10);
        Console.WriteLine(product3);
    }
}
