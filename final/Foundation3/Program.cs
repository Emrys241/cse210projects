using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        // Creating instances of different event types
        Lecture lecture = new Lecture("Introduction to Programming", "Learn the basics of programming",
                                      "2023-07-20", "10:00 AM", "123 Main Street", "Bernard Amegah", 50);

        Reception reception = new Reception("Company Networking Event", "Network with professionals",
                                            "2023-07-25", "6:00 PM", "456 Elm Street", "ame22001@byui.edu", true, false);

        OutdoorGathering gathering = new OutdoorGathering("Summer BBQ", "Enjoy delicious food and games",
                                                          "2023-07-30", "12:00 PM", "789 Oak Street", "Sunny");

        // Displaying event details
        Console.WriteLine("Lecture:");
        lecture.DisplayDetailedMsg();

        Console.WriteLine();

        Console.WriteLine("Reception:");
        reception.DisplayDetailedMsg();

        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        gathering.DisplayDetailedMsg();

        Console.ReadLine();
    }
}
