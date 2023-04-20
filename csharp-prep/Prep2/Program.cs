using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage 0-100: ");
        int score = int.Parse(Console.ReadLine());

        string letter;

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
            Console.WriteLine("Your Letter grade is " + letter + ".");
        {
    }
    }
}