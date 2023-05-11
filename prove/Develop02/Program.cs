using System;

class Program
{
   static void Main(string[] args)
{
    Console.WriteLine("Hello Develop02 World!");

    Journal journal = new Journal();
    Console.WriteLine("Please select one of the following Choices");
    PromptGenerator promptGenerator = new PromptGenerator(new List<string> { "What did you accomplish today?", "What did you learn today?", "How did you improve today?" });

    while (true)
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                journal.CreateJournalEntry(prompt, response);
                break;
            case "2":
                journal.DisplayJournalEntries();
                break;
            case "3":
                journal.LoadFromCSV();
                break;
            case "4":
                journal.SaveToCSV();
                break;
            case "5":
                Console.WriteLine("Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

}