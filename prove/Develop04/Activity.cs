using System;

public class Activity
{
    protected string activityName;
    protected string description;
    protected int duration;

    public Activity(string activityName)
    {
        this.activityName = activityName;
    }

    protected void GetWelcomeMessage()
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
    }

    protected void Animation(string animationType)
    {
        // Code for animation display
    }

    protected void Animation(int countdown)
    {
        // Code for countdown animation display
    }

    protected void SetDuration()
    {
        Console.Write($"Enter the duration (in seconds) for {activityName}: ");
        duration = GetPositiveIntegerInput();
    }

    protected void EndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {activityName} for {duration} seconds.");
    }

    protected void GetReady()
    {
        Console.WriteLine("Get ready to begin...");
        Pause(3);
    }

    protected static void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }

    protected static int GetPositiveIntegerInput()
    {
        int value;
        bool validInput = false;

        do
        {
            string input = Console.ReadLine();
            validInput = int.TryParse(input, out value);

            if (!validInput || value <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                validInput = false;
            }
        } while (!validInput);

        return value;
    }

    public virtual void RunActivity()
    {
        GetWelcomeMessage();
        SetDuration();
        GetReady();
    }
}
