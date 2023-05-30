using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Bernard Amegah", "Mathematics");

        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

          // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Bernard Amegah", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}