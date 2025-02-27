public class Vector3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override string ToString()
    {
        return $"{X},{Y},{Z}";
    }

    public static Vector3D operator +(Vector3D a, Vector3D b)
    {
        Vector3D res = new Vector3D();
        res.X = a.X + b.X;
        res.Y = a.Y + b.Y;
        res.Z = a.Z + b.Z;
        return res;
    }

    public static Vector3D operator -(Vector3D a, Vector3D b)
    {
        Vector3D res = new Vector3D();
        res.X = a.X - b.X;
        res.Y = a.Y - b.Y;
        res.Z = a.Z - b.Z;
        return res;
    }

    public static int operator *(Vector3D a, Vector3D b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z + b.Z;
    }
    
   public static int operator /(Vector3D a, Vector3D b)
   {
       if (b.X == 0 || b.Y == 0 || b.Z == 0)
       {
           throw new DivideByZeroException("Cannot divide by zero component in vector b.");
       }
       else
       {
           return a.X / b.X + a.Y / b.Y + a.Z / b.Z;
       }
   }
   
public static bool operator ==(Vector3D a, Vector3D b)
    {
        return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }

    public static bool operator !=(Vector3D a, Vector3D b)
    {
        return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
    }

    public override bool Equals(object obj)
    {
        if (obj is Vector3D other)
        {
            return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
    }

    public static bool operator false(Vector3D obj)
    {
        return obj.X == 0 && obj.Y == 0 && obj.Z == 0;
    }

    public static bool operator true(Vector3D obj)
    {
        return obj.X != 0 || obj.Y != 0 || obj.Z != 0;
    }
    public static bool operator >(Vector3D a, Vector3D b)
    {
        return (a.X * a.X + a.Y * a.Y + a.Z * a.Z) > (b.X * b.X + b.Y * b.Y + b.Z * b.Z);
    }
    
    public static bool operator <(Vector3D a, Vector3D b)
    {
        return (a.X * a.X + a.Y * a.Y + a.Z * a.Z) < (b.X * b.X + b.Y * b.Y + b.Z * b.Z);
    }
    
    public static bool operator >=(Vector3D a, Vector3D b)
    {
        return (a.X * a.X + a.Y * a.Y + a.Z * a.Z) >= (b.X * b.X + b.Y * b.Y + b.Z * b.Z);
    }
    
    public static bool operator <=(Vector3D a, Vector3D b)
    {
        return (a.X * a.X + a.Y * a.Y + a.Z * a.Z) <= (b.X * b.X + b.Y * b.Y + b.Z * b.Z);
    }
}

class Program
{
    static void Main()
    {
        Vector3D v1 = new Vector3D { X = 3, Y = 4, Z = 5 };
        Vector3D v2 = new Vector3D { X = 1, Y = 2, Z = 3 };
        Vector3D sum = v1 + v2;
        Console.WriteLine(sum);
        Vector3D difference = v1 - v2;
        Console.WriteLine(difference); 
        int dotProduct = v1 * v2;
        Console.WriteLine(dotProduct);
        int division = v1 / v2;
        Console.WriteLine(division);
        bool areEqual = v1 == v2;
        Console.WriteLine(areEqual); 
        if (v1)
        {
            Console.WriteLine("v1 is not-zero");
        }
        bool isGreater = v1 > v2;
        Console.WriteLine(isGreater); 
    }
}
