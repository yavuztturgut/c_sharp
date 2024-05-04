using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Register
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    static List<Register> users = new List<Register>();

    public Register(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }

    public static void Main()
    {
        while(true)
        {
            Console.WriteLine("1 FOR ADD A USER\n2 FOR SEE ALL THE USERS\n3 FOR DELETE A USER");
            string x = Console.ReadLine();
            if (x == "1")
            {
                addUser();
            }
            else if (x == "2")
            {
                printAll();
            }
            else if (x == "3")
            {
                delete();
            }
            else
            {
                Console.WriteLine("invalid input!");
            }
        }
        
    }
    static void addUser()
    {
        Console.WriteLine("Name and surname:");
        string name = Console.ReadLine();

        Console.WriteLine("Age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("City:");
        string city = Console.ReadLine();

        Register user = new Register(name, age, city);
        users.Add(user);

        Console.WriteLine("Registered user information:");
    }
    static void printAll()
    {
        if (users.Count == 0)
        {
            Console.WriteLine("no users.");
        }
        else
        {
            foreach (var u in users)
            {
                Console.WriteLine($"Name: {u.Name}, Age: {u.Age}, City: {u.City}");
            }
        }
    }

    static void delete()
    {
        printAll();
        Console.WriteLine("which user you want to delete? ");
        int y = int.Parse(Console.ReadLine());
        if (users.Count >= y)
        {
            users.RemoveAt(y-1);
            Console.WriteLine("user deleted.");
        }
        else
        {
            Console.WriteLine("invalid input!");
        }
    }
}
