using System;

public class Student
{
    private string[] _subjects;
    private int[] _grades;

    public int this[string subject]
    {
        get
        {
            for (int i = 0; i < _subjects.Length; i++)
            {
                if (_subjects[i] == subject)
                {
                    return _grades[i];
                }
            }
            return -1;
        }
    }

    public Student(string[] subjects, int[] grades)
    {
        _subjects = subjects;
        _grades = grades;
    }
}

class Program
{
    public static void Main()
    {
        string[] subjects = { "Math", "Science", "English", "History" };
        int[] grades = { 85, 90, 78 };

        Student student = new Student(subjects, grades);

        Console.WriteLine(student["Math"]);
        Console.WriteLine(student["Science"]);
        Console.WriteLine(student["History"]);
         Console.WriteLine(student["English"]);
    }
}
