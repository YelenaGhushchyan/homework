public class Person
{
   public int Id { get; private set; }
   public string Name { get; private set; }

   public Person(int id, string name)
   {
       Id = id;
       Name = name;
   }
   
}
public class ContactArray
{
    private Person[] _arr;

    public ContactArray(Person[] array)
    {
        _arr = array;
    }

    public Person this[int Id]
    {
        get
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Id == Id)
                {
                    return _arr[i];
                }
            }

            return null;
        }
    }

    public Person this[string name]
    {
        get
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Name == name)
                {
                    return _arr[i];
                }
            }

            return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Person[] person = 
        {
            new Person(12, "Ann"),
            new Person(13, "John"),
            new Person(14, "Sam")
        };

        ContactArray contactArray = new ContactArray(person);
        Person personId = contactArray[12];
        if (personId != null)
        {
            Console.WriteLine($"Found contact: {personId.Name} (ID: {personId.Id})");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    
        Person personName = contactArray["Sam"]; 
        if (personName != null)
        {
            Console.WriteLine($"Found contact: {personName.Name} (ID: {personName.Id})");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
    }
    
