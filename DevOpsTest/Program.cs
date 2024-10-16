using System.Runtime.InteropServices;

namespace DevOpsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = new List<string>();
            Console.WriteLine($"Available features:{Environment.NewLine}" +
                $"1) Add a new contact{Environment.NewLine}" +
                $"2) View contact list{Environment.NewLine}" +
                $"3) Search contact by name{Environment.NewLine}" +
                $"4) Delete a contact{Environment.NewLine}" +
                $"5) Exit{Environment.NewLine}");

            bool running = true;
            string choice;
            while (running)
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
                    case "3":
                        Console.Write("Search query: ");
                        string searchQuery = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(searchQuery))
                        {
                            Console.WriteLine("Invalid contact name provided.");
                        }
                        else if (contacts.Contains(searchQuery))
                        {
                            Console.WriteLine($"\"{searchQuery}\" is in the contact list.");
                        }
                        else
                        {
                            Console.WriteLine($"\"{searchQuery}\" is NOT in the contact list.");
                        }
                        break;
                    case "4":
                        Console.Write("Contact name: ");
                        string contactToRemove = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(contactToRemove))
                        {
                            Console.WriteLine("Invalid contact name provided.");
                        }
                        else if (contacts.Contains(contactToRemove))
                        {
                            contacts.Remove(contactToRemove);
                            Console.WriteLine($"\"{contactToRemove}\" has been removed from the contact list.");
                        }
                        else
                        {
                            Console.WriteLine($"\"{contactToRemove}\" is NOT in the contact list.");
                        }
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Unknown feature.");
                        break;
                }
            }
        }
    }
}
