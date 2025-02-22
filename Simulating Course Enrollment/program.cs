public class Course
{
    public string CourseName;
    public string Instructor;
    public int MaxStudents;

    public Course(string courseName, string instructor, int maxStudents)
    {
        CourseName = courseName;
        Instructor = instructor;
        MaxStudents = maxStudents;
    }

    public void Print()
    {
        Console.WriteLine("Course Name: {0}", CourseName);
        Console.WriteLine("Instructor: {0}", Instructor);
        Console.WriteLine("Max Students: {0}", MaxStudents);
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course("Math", "BILL", 12);
        Course course2 = new Course("English", "Ann", 14);
        course1.Print();
        course2.Print();
    }
}
