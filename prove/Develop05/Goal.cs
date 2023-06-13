using System;

namespace Develop05
{
    public abstract class Goal
    {
        public string Description { get; }
        public int Value { get; }
        public bool IsComplete { get; set; }

        public Goal(string description, int value)
        {
            Description = description;
            Value = value;
            IsComplete = false;
        }

        public abstract string GetStatus();

        public virtual void RecordEvent(string eventDetails)
        {
            Console.WriteLine("Event recorded for the goal: " + eventDetails);
        }
    }
}
