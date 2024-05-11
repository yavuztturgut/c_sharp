using System;
using System.Collections.Generic;

public interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }
    string City { get; set; }
}

public class Student : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

public class Teacher : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

public class Staff : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

public class PersonManager
{
    public List<IPerson> persons { get; set; }

    public PersonManager()
    {
        persons = new List<IPerson>();
    }

    public void AddPerson(IPerson person)
    {
        persons.Add(person);
    }
}

class Program
{
    static void Main()
    {
        PersonManager manager = new PersonManager();

        Student student = new Student { Name = "Yavuz", Age = 20, City = "Ankara" };
        Teacher teacher = new Teacher { Name = "İbrahim", Age = 8, City = "Trabzon" };
        Staff staff = new Staff { Name = "Oktay", Age = 40, City = "Adıyaman" };

        manager.AddPerson(student);
        manager.AddPerson(teacher);
        manager.AddPerson(staff);

        foreach (var person in manager.persons)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.City}");
        }
    }
}
