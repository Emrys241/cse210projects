namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        public int CompletionCount { get; }
        public int TargetCount { get; }

        public ChecklistGoal(string description, int value, int completionCount, int targetCount, bool completed = false) : base(description, value)
        {
            CompletionCount = completionCount;
            TargetCount = targetCount;
            IsComplete = completed;
        }

        public override string GetStatus()
        {
            if (IsComplete)
            {
                return "Complete";
            }
            else if (CompletionCount < TargetCount)
            {
                return "Incomplete";
            }
            else
            {
                return "In Progress";
            }
        }
    }
}
