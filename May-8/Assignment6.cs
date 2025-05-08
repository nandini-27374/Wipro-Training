using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>
        {
            {"Yamuna","6303154516" },
            {"Bhavi", "9652466479" },
            {"Cherry","7098764563" },
            {"Joshu","9700688749" },
            {"Chocky","9440183750" }
        };

        contacts["Bhavi"] = "9030679014";

        string name = "Cherry";

        if (contacts.ContainsKey(name))
        {
            Console.WriteLine($"{name} is in the contact list.");
        }
        else
        {
            Console.WriteLine($"{name} is not in the contact list.");
        }

        Console.WriteLine("\nAll Contacts:");

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Key}:{contact.Value}");
        }
    }
}