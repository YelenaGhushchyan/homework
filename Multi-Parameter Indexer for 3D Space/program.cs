using System;

public class Grid3D
{
    private int[,,] grid;

    public Grid3D(int Size1, int Size2, int Size3)
    {
        grid = new int[Size1, Size2, Size3];
    }

    public int this[int x, int y, int z]
    {
        get
        {
            if (x < 0 || x >= grid.GetLength(0) || y < 0 || y >= grid.GetLength(1) || z < 0 || z >= grid.GetLength(2))
            {
                throw new ArgumentOutOfRangeException($"Index out of bounds: ({x}, {y}, {z}).");
            }
            return grid[x, y, z];
        }
        set
        {
            if (x < 0 || x >= grid.GetLength(0) || y < 0 || y >= grid.GetLength(1) || z < 0 || z >= grid.GetLength(2))
            {
                throw new ArgumentOutOfRangeException($"Index out of bounds: ({x}, {y}, {z}).");
            }
            grid[x, y, z] = value;
        }
    }
}

class Program
{
    public static void Main()
    {
        Grid3D grid = new Grid3D(3, 3, 3);

        grid[0, 0, 0] = 1;
        grid[1, 1, 1] = 2;
        grid[2, 2, 2] = 3;

        Console.WriteLine(grid[0, 0, 0]);
        Console.WriteLine(grid[1, 1, 1]);
        Console.WriteLine(grid[2, 2, 2]);
    }
}
