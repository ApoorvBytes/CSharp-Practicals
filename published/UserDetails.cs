using System;

class UserDetails
{
    static void Main()
    {
        string name;
        int age;
        string address;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your address: ");
        address = Console.ReadLine();

        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Address: " + address);
    }
}
