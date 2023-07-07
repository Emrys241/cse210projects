using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running running = new Running("2023-07-06", 30, 5.5);
        Swimming swimming = new Swimming("2023-07-06", 50, 10);
        Cycling cycling = new Cycling("2023-07-06", 25, 15);

        Console.WriteLine("Running:");
        Console.WriteLine("Distance: " + running.CalculateDistance());
        Console.WriteLine("Speed: " + running.CalculateSpeed());
        Console.WriteLine("Pace: " + running.CalculatePace());

        Console.WriteLine("\nSwimming:");
        Console.WriteLine("Distance: " + swimming.CalculateDistance());
        Console.WriteLine("Speed: " + swimming.CalculateSpeed());
        Console.WriteLine("Pace: " + swimming.CalculatePace());

        Console.WriteLine("\nCycling:");
        Console.WriteLine("Distance: " + cycling.CalculateDistance());
        Console.WriteLine("Speed: " + cycling.CalculateSpeed());
        Console.WriteLine("Pace: " + cycling.CalculatePace());
    }
}
