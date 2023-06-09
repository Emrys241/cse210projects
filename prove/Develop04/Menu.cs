using System;

class Menu
{
    public void ShowMenuOptions()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listening Activity");
        Console.WriteLine("4. Quit");
    }

    public int GetUserChoice()
    {
        int choice = 0;
        bool validChoice = false;

        while (!validChoice)
        {
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                if (choice >= 1 && choice <= 4)
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        return choice;
    }
}
