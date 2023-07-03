using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static ScoreManager scoreManager = new ScoreManager();

    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        while (true)
        {
            Console.WriteLine("Select a choice from the menu:");
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
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateNewGoal()
{
    Console.WriteLine("Goal Types:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");

    Console.WriteLine("Which type of goal would you like to create?");
    string goalType = Console.ReadLine();

    Console.WriteLine("What is the name of your goal?");
    string name = Console.ReadLine();

    Console.WriteLine("What is a short description of it?");
    string description = Console.ReadLine();

    Console.WriteLine("What is the amount of points associated with this goal?");
    int points = int.Parse(Console.ReadLine()); // Read the value for 'points' from user input

    switch (goalType)
    {
        case "1":
            goals.Add(new SimpleGoal(name, description, points));
            break;
        case "2":
            goals.Add(new EternalGoal(name, description, points));
            break;
        case "3":
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int requiredTimes = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonusPoints = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, description, points, bonusPoints, requiredTimes));
            break;
        default:
            Console.WriteLine("Invalid goal type. Goal creation cancelled.");
            break;
    }

    Console.WriteLine("Goal created successfully.");
}

    static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetStatus()} {goal.Name} ({goal.Description})");

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"   Completed {checklistGoal.TimesCompleted}/{checklistGoal.RequiredTimes} times");
            }
        }

        Console.WriteLine($"You have {scoreManager.TotalPoints} points.");
    }

    static void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                string goalString = $"{goal.GetType().Name}:{goal.Name},{goal.Description},{goal.Points}";

                if (goal is SimpleGoal)
                {
                    goalString += ",False";
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    goalString += $",{checklistGoal.BonusPoints},{checklistGoal.RequiredTimes},{checklistGoal.TimesCompleted}";
                }

                file.WriteLine(goalString);
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        goals.Clear();

        using (System.IO.StreamReader file = new System.IO.StreamReader(filename))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid goal data. Skipping line: " + line);
                    continue;
                }

                string[] goalData = parts[1].Split(',');

                if (parts[0] == "SimpleGoal")
                {
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    bool isCompleted = bool.Parse(goalData[3]);
                    goals.Add(new SimpleGoal(name, description, points) { IsCompleted = isCompleted });
                }
                else if (parts[0] == "EternalGoal")
                {
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    goals.Add(new EternalGoal(name, description, points));
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    bool isCompleted = bool.Parse(goalData[3]);
                    int bonusPoints = int.Parse(goalData[4]);
                    int requiredTimes = int.Parse(goalData[5]);
                    int timesCompleted = int.Parse(goalData[6]);
                    goals.Add(new ChecklistGoal(name, description, points, bonusPoints, requiredTimes)
                    {
                        IsCompleted = isCompleted,
                        TimesCompleted = timesCompleted
                    });
                }
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    static void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetStatus()} {goal.Name} ({goal.Description})");
        }

        Console.WriteLine("What goal did you accomplish?");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex < 0 || goalIndex >= goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal selectedGoal = goals[goalIndex];
        selectedGoal.CompleteGoal();
        scoreManager.AddPoints(selectedGoal.Points);

        if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
        {
            scoreManager.AddPoints(checklistGoal.BonusPoints);
        }

        Console.WriteLine("Congratulations! You have earned points!");
        Console.WriteLine($"You now have {scoreManager.TotalPoints} points.");
    }
}
