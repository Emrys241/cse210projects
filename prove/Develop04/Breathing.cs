using System;

class BreathingActivity : Activity
{
    private string breathIn;
    private string breathOut;

    public BreathingActivity() : base("Breathing Activity")
    {
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        breathIn = "Breathe in...";
        breathOut = "Breathe out...";
    }

    public override void RunActivity()
    {
        base.RunActivity();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(breathIn);
            Animation("spinner");
            Pause(3);

            if (DateTime.Now >= endTime)
            {
                Console.WriteLine("Time's up!");
                EndingMessage();
                return;
            }

            Console.WriteLine(breathOut);
            Animation("spinner");
            Pause(3);

            if (DateTime.Now >= endTime)
            {
                Console.WriteLine("Time's up!");
                EndingMessage();
                return;
            }
        }

        Console.WriteLine("Time's up!");
        EndingMessage();
    }
}
