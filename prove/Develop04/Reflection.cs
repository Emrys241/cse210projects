using System;

class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionPrompts = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity")
    {
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void RunActivity()
    {
        base.RunActivity();

        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Animation("spinner");
            Pause(3);

            foreach (string reflectionPrompt in reflectionPrompts)
            {
                Console.WriteLine(reflectionPrompt);
                Animation("spinner");
                Pause(5);

                if (DateTime.Now >= endTime)
                {
                    Console.WriteLine("Time's up!");
                    EndingMessage();
                    return;
                }
            }
        }

        Console.WriteLine("Time's up!");
        EndingMessage();
    }
}
