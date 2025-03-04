using System;
public class Person
{

    public string FirstName { get; set; }
    public string LastName { get; set; }

    private string _fullName;

    
    public string FullName
    {
        get
        {
            if (_fullName == null)
            {
                _fullName = $"{FirstName} {LastName}";
            }
            return _fullName;
        }
    }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Program
{
    public static void Main()
    {
        
        Person person = new Person("Sam", "Smith");
        Console.WriteLine(person.FullName); 
        person.FirstName = "Jane";
        person.LastName = "Ali";
        Console.WriteLine(person.FullName);
    }
}
