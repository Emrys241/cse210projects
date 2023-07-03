public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }
    public bool IsCompleted { get; set; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void CompleteGoal();
    public abstract string GetStatus();
}
