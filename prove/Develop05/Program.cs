using System;
using System.Collections.Generic;
using System.IO;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Develop05 World!");
            Console.WriteLine("Welcome to Goal Tracker!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateNewGoal();
                        break;
                    case "2":
                        ListGoals();
                        break;
                    case "3":
                        SaveData();
                        break;
                    case "4":
                        LoadData();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        Console.WriteLine("Thank you for using Goal Tracker. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreateNewGoal()
        {
            Console.WriteLine("Enter goal description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter goal value:");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Goal goal;
            switch (choice)
            {
                case "1":
                    goal = new SimpleGoal(description, value);
                    break;
                case "2":
                    goal = new EternalGoal(description, value);
                    break;
                case "3":
                    Console.WriteLine("Enter completion count:");
                    int completionCount = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter target count:");
                    int targetCount = int.Parse(Console.ReadLine());

                    goal = new ChecklistGoal(description, value, completionCount, targetCount);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Creating a simple goal by default.");
                    goal = new SimpleGoal(description, value);
                    break;
            }

            Data.goals.Add(goal);

            Console.WriteLine("Goal created successfully.");
        }

        static void ListGoals()
        {
            Console.WriteLine("List of Goals:");
            if (Data.goals.Count > 0)
            {
                for (int i = 0; i < Data.goals.Count; i++)
                {
                    Goal goal = Data.goals[i];
                    Console.WriteLine($"Goal {i + 1}: {goal.Description} | Value: {goal.Value} | Status: {goal.GetStatus()}");
                }
            }
            else
            {
                Console.WriteLine("No goals found.");
            }
        }

        static void SaveData()
        {
            Console.WriteLine("Enter file name to save goals:");
            string fileName = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (Goal goal in Data.goals)
                    {
                        writer.WriteLine($"{goal.Description},{goal.Value},{goal.IsComplete}");
                    }
                }

                Console.WriteLine("Goals saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save goals. Error: {ex.Message}");
            }
        }

        static void LoadData()
        {
            Console.WriteLine("Enter file name to load goals:");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            try
            {
                Data.goals.Clear();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 3)
                        {
                            string description = parts[0];
                            int value = int.Parse(parts[1]);
                            bool isComplete = bool.Parse(parts[2]);

                            Goal goal = new SimpleGoal(description, value);
                            goal.IsComplete = isComplete;

                            Data.goals.Add(goal);
                        }
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load goals. Error: {ex.Message}");
            }
        }

        static void RecordEvent()
        {
            Console.WriteLine("Enter goal number:");
            int goalNumber = int.Parse(Console.ReadLine());

            if (goalNumber >= 1 && goalNumber <= Data.goals.Count)
            {
                Goal goal = Data.goals[goalNumber - 1];
                Console.WriteLine($"Recording event for goal: {goal.Description}");

                Console.WriteLine("Enter event description:");
                string eventDescription = Console.ReadLine();

                goal.RecordEvent(eventDescription);

                Console.WriteLine("Event recorded successfully.");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
    }
}
