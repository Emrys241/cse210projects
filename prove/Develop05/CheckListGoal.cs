public class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int RequiredTimes { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int requiredTimes)
        : base(name, description, points)
    {
        TimesCompleted = 0;
        RequiredTimes = requiredTimes;
        BonusPoints = bonusPoints;
    }

    public override void CompleteGoal()
    {
        TimesCompleted++;
        if (TimesCompleted >= RequiredTimes)
        {
            IsCompleted = true;
        }
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
