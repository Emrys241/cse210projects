public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void CompleteGoal()
    {
        // For eternal goals, mark them as completed without any specific logic
        IsCompleted = true;
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
