using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Bernard Amegah", "Mathematics");

        string summary = assignment.GetSummary();
        Console.WriteLine(summary);
    }
}