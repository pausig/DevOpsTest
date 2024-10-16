﻿namespace DevOpsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = new List<string>();
            Console.WriteLine($"Available features:{Environment.NewLine}" +
                $"1) Add a new contact{Environment.NewLine}" +
                $"2) View contact list{Environment.NewLine}");

            string choice;
            while (true)
            {
                Console.Write("Choose a feature: ");
                choice = Console.ReadLine() ?? string.Empty;
                switch (choice)
                {
                    case "1":
                        Console.Write("New contact name: ");
                        string contactName = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(contactName))
                        {
                            Console.WriteLine("Invalid contact name provided.");
                        }
                        else if (contacts.Contains(contactName))
                        {
                            Console.WriteLine($"A contact named \"{contactName}\" already exists.");
                        }
                        else
                        {
                            contacts.Add(contactName);
                            Console.WriteLine($"Successfully added \"{contactName}\" to contacts.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Contact list:");
                        foreach (var item in contacts)
                        {
                            Console.WriteLine($" |- {item}");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown feature.");
                        break;
                }
            }
        }
    }
}
