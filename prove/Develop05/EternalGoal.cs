namespace Develop05
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string description, int value) : base(description, value)
        {
        }

        public override string GetStatus()
        {
            return "Eternal";
        }
    }
}
