using System;

class ListeningActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListeningActivity() : base("Listening Activity")
    {
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void RunActivity()
    {
        base.RunActivity();

        Random random = new Random();
        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Animation("spinner");
            Pause(3);

            Console.WriteLine("Start listing items. Press 'Q' to finish.");
            string response;
            int count = 0;
            bool timeIsUp = false;
            DateTime startTime = DateTime.Now;

            do
            {
                response = Console.ReadLine();
                if (response.ToLower() != "q")
                {
                    count++;
                }

                // Check if time is up
                if ((DateTime.Now - startTime).TotalSeconds >= duration)
                {
                    timeIsUp = true;
                    break;
                }
            } while (response.ToLower() != "q");

            Console.WriteLine($"You listed {count} items.");

            if (timeIsUp)
            {
                Console.WriteLine("Time is up. Exiting the activity.");
                break;
            }
        }

        EndingMessage();
    }

}

