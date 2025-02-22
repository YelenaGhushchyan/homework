public class Movie
{
    private int _rating;

    public int Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            if (value >= 0 && value <= 5)
            {
                _rating = value;
            }
            else
            
                {
                    Console.WriteLine("Invalid rating");
                }
            }
        }
    }

    public Movie(int Rating)
    {
        this.Rating = Rating;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Movie movie1 = new Movie(5);
        Console.WriteLine(movie1.Rating);
        Movie movie2 = new Movie(10);
        Console.WriteLine(movie2.Rating);
    }
    
}
