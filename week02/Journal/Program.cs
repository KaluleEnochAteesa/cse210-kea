// program has option five to show saved journals also creates deflault folder for journal storage
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string journalDirectory = Path.Combine(Directory.GetCurrentDirectory(), "SavedJournals");

        // Create the "SavedJournals" directory if it doesn't exist
        if (!Directory.Exists(journalDirectory))
        {
            Directory.CreateDirectory(journalDirectory);
            Console.WriteLine($"Directory '{journalDirectory}' created.");
        }

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. List all saved journals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry entry = new Entry(date, prompt, entryText);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save with .txt at the end of the name you give it: ");
                    string saveFilename = Console.ReadLine();
                    string savePath = Path.Combine(journalDirectory, saveFilename);
                    journal.SaveToFile(savePath);
                    Console.WriteLine($"Journal saved to {savePath}"); // Debug statement
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    string loadPath = Path.Combine(journalDirectory, loadFilename);
                    journal.LoadFromFile(loadPath);
                    Console.WriteLine($"Journal loaded from {loadPath}"); // Debug statement
                    break;
                case "5":
                    Console.WriteLine($"Listing journals in directory: {journalDirectory}"); // Debug statement
                    Journal.ListSavedJournals(journalDirectory);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}