using System;

namespace GoalManagement
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the EternalQuest Project.");
            GoalManager goalManager = new GoalManager();
            goalManager.LoadGoals("goals.txt"); // Load goals from file
            goalManager.Start();
            goalManager.SaveGoals("goals.txt"); // Save goals to file
        }
    }

}

