using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Menu menu = new Menu();
        Activity activity = null;

        while (true)
        {
            menu.ShowMenuOptions();
            int choice = menu.GetUserChoice();

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListeningActivity();
                    break;
                case 4:
                    return;
            }

            if (activity != null)
            {
                activity.RunActivity();
            }
        }
    }
}
