public class Student
{
    public string FirstName { get; set; }
    public int studentId { get; set; }
    public float gradeLevel { get; set; }

    public void ShowStudentInfo()
    {
        Console.WriteLine("Name: " + FirstName);
        Console.WriteLine("Student ID: " + studentId);
        Console.WriteLine("Grade Level: " + gradeLevel);
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Student[] student = new Student[3];
        for (int i = 0; i < student.Length; i++)
        {
            student[i] = new Student();
            Console.WriteLine("Enter first name:" );
            student[i].FirstName = Console.ReadLine();
            Console.WriteLine("Enter studentID:");
            student[i].studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gradeLevel:");
            student[i].gradeLevel = float.Parse(Console.ReadLine());
            student[i].ShowStudentInfo();
        }
    }
}
