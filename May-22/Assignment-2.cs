/*

Build a phone book using Dictionary<string, string> .
Instructions:
1. Create a dictionary with name as key and phone number as value.
2. Add 3 contacts.
3. Display all contacts.
4. Ask the user for a name and display the phone number (if found).

*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string,string> phonebook = new Dictionary<string,string>();

        phonebook.Add("Yamuna", "9876784537");
        phonebook.Add("Nandini", "8765675432");
        phonebook.Add("Bhavya", "8008113456");

        foreach (var phonebk in phonebook)
        {
            Console.WriteLine(phonebk);
        }

        Console.WriteLine("\n Enter the name to search");
        string name = Console.ReadLine();

        if (phonebook.ContainsKey(name))
        {
            string phonenumber = phonebook[name];
            Console.WriteLine($"Phone number for the {name} is: {phonenumber}");
        }
        else
            Console.WriteLine($"Contact {name} not found");
    }
}

/*
Output:

[Yamuna, 9876784537]
[Nandini, 8765675432]
[Bhavya, 8008113456]

Enter the name to search
Nandini
Phone number for the Nandini is: 8765675432

*/

