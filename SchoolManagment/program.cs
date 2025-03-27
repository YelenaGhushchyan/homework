public enum courses
{
    Web,
    Cpp,
    CSharp
}

public enum Role
{
    WebInstructor,
    CppInstructor,
    CSharpInstructor
}

class School
{
    public string Name { get; }
    public string Address { get; }
    public string Email { get; }
    public string PhoneNumber { get; }
    private Course[] _courses;
    private Student[] _students;
    private Instructor[] _instructors;

    public School(string name, string address, string email, string phoneNumber, int coursesCount, int studentsCount, int instructorsCount)
    {
        Name = name;
        Address = address;
        Email = email;
        PhoneNumber = phoneNumber;
        _courses = new Course[coursesCount];
        _students = new Student[studentsCount];
        _instructors = new Instructor[instructorsCount];
    }
    private string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };


    public Course this[int index]
    {
        get
        {
            if (index < 0 || index >= _courses.Length)
            {
                throw new IndexOutOfRangeException("out of range");
            }

            return _courses[index];
        }
        set
        {
            if (index < 0 || index >= _courses.Length)
            {
                throw new IndexOutOfRangeException("out of range");
            }

            _courses[index] = value;
        }
    }

    public Student this[string name]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Name == name)
                {
                    return _students[i];
                }
            }
            Console.WriteLine($"No student with name {name}");
            return null; 
        }
    }

    public Instructor this[Role role]
    {
        get
        {
            foreach (var instructor in _instructors)
            {
                if (instructor.Role == role)
                {
                    return instructor;
                }
            }
            Console.WriteLine($"No instructor found for the role {role}");
            return null;
        }
    }

    public void AddStudent(Student student)
    {
        for (int i = 0; i < _students.Length; i++)
        {
            if (_students[i] == null)
            {
                _students[i] = student;
                Console.WriteLine($"{student} is added");
                return;
            }
        }
        Console.WriteLine($"{student} is not added");
    }

    public void RemoveStudent(string studentName)
    {
        for (int i = 0; i < _students.Length; i++)
        {
            if (_students[i].Name == studentName)
            {
                _students[i] = null;
                Console.WriteLine($"{studentName} is removed");
                return;
            }
        }
        Console.WriteLine($"{studentName} is not removed");
    }

    public void CourseDiscount(Student student)
    {
        for (int i = 0; i < _courses.Length; i++)
        {
            if (student.Gpa > 80)
            {
                _courses[i].price *= 0.9f;
                Console.WriteLine($"Discount applied to course {_courses[i].CourseType} for student {student.Name}");
            }
        }
    }
    public void GenerateSchedule()
    {
        Console.WriteLine("Schedule for the week:");
        foreach (var course in _courses)
        {
            foreach (var instructor in _instructors)
            {
                if (instructor.Role == GetInstructorRoleForCourse(course))
                {
                    string day = daysOfWeek[new Random().Next(daysOfWeek.Length)];
                    Console.WriteLine($"{course.CourseType} by {instructor.Role} on {day}");
                    break;
                }
            }
        }
    }

    private Role GetInstructorRoleForCourse(Course course)
    {
        switch (course.CourseType)
        {
            case courses.Web:
                return Role.WebInstructor;
            case courses.Cpp:
                return Role.CppInstructor;
            case courses.CSharp:
                return Role.CSharpInstructor;
            default:
                throw new Exception("Unsupported course");
        }
    }

    public string CheckAbsance()
    {
        for (int i = 0; i < _students.Length; i++)
        {
            if (_students[i].Absance >= 3)
            {
                string removedStudentName = _students[i].Name;
                RemoveStudent(_students[i].Name);
                return removedStudentName;
            }
        }

        return "No student removed"; // Եթե ոչ ոք չի հեռացվել
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"School: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine();
        
        Console.WriteLine("Courses:");
        foreach (var course in _courses)
        {
            if (course != null)
            {
                Console.WriteLine($"- {course.CourseType} (Price: {course.price})");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Students:");
        foreach (var student in _students)
        {
            if (student != null)
            {
                Console.WriteLine($"- {student.Name} (GPA: {student.Gpa})");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Instructors:");
        foreach (var instructor in _instructors)
        {
            if (instructor != null)
            {
                Console.WriteLine($"- {instructor.Role} ({instructor.Name})");
            }
        }
        Console.WriteLine();
    }

}

class Course
{
    private string[] topics;
    
    public courses CourseType { get; } 
    public float price { get; set; }

    public Course(courses courseType, float price, string[] topics = null)
    {
        CourseType = courseType;
        this.price = price;
        this.topics = topics ?? new string[0];  
    }
    public void DisplayTopics()
    {
        Console.WriteLine($"Topics for {CourseType}:");
        if (topics.Length == 0)
        {
            Console.WriteLine("No topics available.");
            return;
        }
        foreach (var topic in topics)
        {
            Console.WriteLine($"  - {topic}");
        }
    }

}

class Student
{
    public string Name { get; }
    public int Absance { get; private set; }
    public float Gpa { get; }
    
    private Course[] _courses; 

    public Student(string name, int absance, float gpa, int maxCourses)
    {
        Name = name;
        Absance = absance;
        Gpa = gpa;
        _courses = new Course[maxCourses];
    }

    public void RegisterToCourse(Course course)
    {
        for (int i = 0; i < _courses.Length; i++)
        {
            if (_courses[i] == null)
            {
                _courses[i] = course;
                Console.WriteLine($"{Name} registered to {course.CourseType}");
                return;
            }
        }
        Console.WriteLine($"{Name} cannot register to {course.CourseType}, max courses reached!");
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"{Name} is registered to:");
        foreach (var course in _courses)
        {
            if (course != null)
            {
                Console.WriteLine($"  - {course.CourseType}");
            }
        }
    }
}

class Instructor
{
    public string Name { get; }
    public Role Role { get; }
    
    private Course[] _assignedCourses; 

    public Instructor(string name, Role role, int maxCourses)
    {
        Name = name;
        Role = role;
        _assignedCourses = new Course[maxCourses];
    }

    public void AssignCourse(Course course)
    {
        for (int i = 0; i < _assignedCourses.Length; i++)
        {
            if (_assignedCourses[i] == null)
            {
                _assignedCourses[i] = course;
                Console.WriteLine($"{Name} is assigned to {course.CourseType}");
                return;
            }
        }
        Console.WriteLine($"{Name} cannot take more courses!");
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"{Name} is teaching:");
        foreach (var course in _assignedCourses)
        {
            if (course != null)
            {
                Console.WriteLine($"  - {course.CourseType}");
            }
        }
    }
}
class Program
{
    static void Main()
    {
        School school = new School("Elite School", "123 Main St", "info@elite.edu", "555-1234", 3, 5, 3);
        Course webCourse = new Course(courses.Web, 500, new string[] { "HTML", "CSS", "JavaScript" });
        Course cppCourse = new Course(courses.Cpp, 600, new string[] { "Variables", "Loops", "Pointers" });
        Course csharpCourse = new Course(courses.CSharp, 700, new string[] { "OOP", "LINQ", "Delegates" });
        
        school[0] = webCourse;
        school[1] = cppCourse;
        school[2] = csharpCourse;

        Instructor webInstructor = new Instructor("Alice", Role.WebInstructor, 2);
        Instructor cppInstructor = new Instructor("Bob", Role.CppInstructor, 2);
        Instructor csharpInstructor = new Instructor("Charlie", Role.CSharpInstructor, 2);

        webInstructor.AssignCourse(webCourse);
        cppInstructor.AssignCourse(cppCourse);
        csharpInstructor.AssignCourse(csharpCourse);

        Student student1 = new Student("John", 1, 85, 2);
        Student student2 = new Student("Emma", 0, 78, 2);
        Student student3 = new Student("Mike", 3, 90, 2);

        student1.RegisterToCourse(webCourse);
        student2.RegisterToCourse(cppCourse);
        student3.RegisterToCourse(csharpCourse);

        school.AddStudent(student1);
        school.AddStudent(student2);
        school.AddStudent(student3);

        school.DisplayInfo();

        string removedStudent = school.CheckAbsance();
        Console.WriteLine($"Removed student: {removedStudent}");
        school.GenerateSchedule();
    }
}
