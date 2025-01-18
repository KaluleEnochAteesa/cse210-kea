using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Reading line: {line}"); // Debug statement
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[2]);
                        _entries.Add(entry);
                        Console.WriteLine("Entry added successfully."); // Debug statement
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry format: {line}"); // Debug statement
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    public static void ListSavedJournals(string directory)
    {
        try
        {
            string[] files = Directory.GetFiles(directory, "*.txt");
            Console.WriteLine("Saved Journals:");
            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error listing saved journals: {ex.Message}");
        }
    }
}