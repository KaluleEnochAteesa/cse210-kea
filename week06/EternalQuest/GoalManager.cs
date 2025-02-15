using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private const string Yellow = "\u001b[33m";
    private const string Reset = "\u001b[0m";

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string userInput;
        do
        {
            DisplayMenu();
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    DisplayPlayerInfo();
                    break;
                case "5":
                    SaveGoals("goals.txt");
                    break;
                case "6":
                    LoadGoals("goals.txt");
                    break;
                case "0":
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        } while (userInput != "0");
    }

    private void DisplayMenu()
    {
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. List goal details");
        Console.WriteLine("4. Display player info");
        Console.WriteLine("5. Save goals");
        Console.WriteLine("6. Load goals");
        Console.WriteLine("0. Exit");
        Console.Write("Select an option: ");
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType.ToLower())
        {
            case "simple":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                Console.Write("Enter target number of times: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.Write("Enter the number of the goal: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsAwarded = _goals[goalIndex].RecordEvent();
            _score += pointsAwarded;
            Console.WriteLine($"Event recorded! You earned {Yellow}{pointsAwarded}{Reset} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score); // Save the score first
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]); // Load the score first
            _goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string goalType = parts[0];
                switch (goalType)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                        break;
                }
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {Yellow}{_score}{Reset}");
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
}
