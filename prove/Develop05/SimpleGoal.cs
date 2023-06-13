namespace Develop05
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string description, int value) : base(description, value)
        {
        }

        public override string GetStatus()
        {
            return IsComplete ? "Complete" : "Incomplete";
        }
    }
}
